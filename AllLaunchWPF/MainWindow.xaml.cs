using AllLaunchCore;
using System.Windows;

namespace AllLaunchWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { 
            InitializeComponent();

            DataContext = new MainWindowViewModel(this);
        }

        private void AppWindow_Activated(object sender, System.EventArgs e)
        {
            // Hide overlay when focus is present
            (DataContext as MainWindowViewModel).OverlayVisible = Visibility.Hidden;
        }

        private void AppWindow_Deactivated(object sender, System.EventArgs e)
        {
            // Show overlay when focus is not present
            (DataContext as MainWindowViewModel).OverlayVisible = Visibility.Visible;
        }
    }
}
