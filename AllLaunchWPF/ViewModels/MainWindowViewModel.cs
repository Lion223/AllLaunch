using AllLaunchCore;
using System.Windows;
using System.Windows.Input;

namespace AllLaunchWPF
{
    /// <summary>
    /// ViewModel for the custom window
    /// </summary>
    public class MainWindowViewModel : BaseViewModel
    {
        #region Private members

        /// <summary>
        /// Window variable that holds the MainWindow's Window (root) object reference
        /// </summary>
        private Window _window;
        /// <summary>
        /// Window's outer margin for drop shadow purpose
        /// </summary>
        private int _outerMarginSize = 5;
        /// <summary>
        /// Dock position for proper resize 
        /// </summary>
        private WindowDockPosition _dockPosition = WindowDockPosition.Undocked;
        /// <summary>
        /// Original width of the window (exclude margin)
        /// </summary>
        private double _minWidth = 396;

        #endregion

        #region Public properties

        /// <summary>
        /// Minimal size of the window
        /// Width has to include margin from the both sides to have designed width
        /// </summary>
        public double MinHeight { get; set; } = 500;
        public double MinWidth
        {
            get => _minWidth + (OuterMarginSize * 2);
            set => _minWidth = value;
        }
        /// <summary>
        /// Resize cursor properties
        /// </summary>
        public bool Borderless => (_window.WindowState == WindowState.Maximized || _dockPosition != WindowDockPosition.Undocked);
        public int ResizeBorderSize => Borderless ? 0 : _outerMarginSize;
        public Thickness ResizeBorderThickness => new Thickness(ResizeBorderSize + OuterMarginSize);
        public int OuterMarginSize
        {
            get => Borderless ? 0 : _outerMarginSize;
            set => _outerMarginSize = value;
        }
        public Thickness OuterMarginSizeThickness => new Thickness(OuterMarginSize);
        /// <summary>
        /// Title bar height
        /// </summary>
        public double TitleHeight { get; set; } = 48;
        public GridLength TitleHeightGridLength => new GridLength(TitleHeight + ResizeBorderSize);

        #endregion

        #region Commands

        /// <summary>
        /// Title bar window commands
        /// </summary>
        public ICommand MenuCommand { get; set; }
        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Receive a window this ViewModel will control
        /// It violates MVVM by parameterizing UI control, creating tightly-coupled connection
        /// </summary>
        /// <param name="window"></param>
        public MainWindowViewModel(Window window)
        {
            _window = window;

            _window.StateChanged += (sender, e) => WindowResized();

            MenuCommand = new Command(() => SystemCommands.ShowSystemMenu(_window, MousePosition.GetMousePosition(_window)));
            MinimizeCommand = new Command(() => _window.WindowState = WindowState.Minimized);
            // Normal state has 0 in value, and Maximized - 2, so instead of ternary operator, a XOR operator can be used to toggle between values of 0 and 2
            MaximizeCommand = new Command(() => _window.WindowState ^= WindowState.Maximized);
            CloseCommand = new Command(() => _window.Close());

            var resizer = new WindowResizer(_window);

            resizer.WindowDockChanged += (dock) =>
            {
                _dockPosition = dock;
                WindowResized();
            };
        }

        #endregion

        #region Private helpers

        /// <summary>
        /// Refresh all window properties when its resized
        /// </summary>
        private void WindowResized()
        {
            // Fire off events for all properties that are affected by a resize
            OnPropertyChanged(nameof(Borderless));
            OnPropertyChanged(nameof(ResizeBorderThickness));
            OnPropertyChanged(nameof(OuterMarginSize));
            OnPropertyChanged(nameof(OuterMarginSizeThickness));
            OnPropertyChanged(nameof(MinWidth));
        }

        #endregion
    }
}
