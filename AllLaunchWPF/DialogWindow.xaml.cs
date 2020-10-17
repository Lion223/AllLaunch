using AllLaunchCore;
using System.Windows;
using System.Windows.Controls;

namespace AllLaunchWPF
{
    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        #region Private members

        /// <summary>
        /// The view model for this window
        /// </summary>
        private DialogWindowViewModel _viewModel;

        #endregion

        #region Public members

        /// <summary>
        /// The view model for this window
        /// </summary>
        public DialogWindowViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                // Set the value
                _viewModel = value;

                // Update the context
                DataContext = _viewModel;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public DialogWindow()
        {
            InitializeComponent();
            DataContext = new DialogWindowViewModel(this);
        }

        #endregion
    }
}
