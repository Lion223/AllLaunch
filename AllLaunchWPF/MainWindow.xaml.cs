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
    }
}
