using AllLaunchCore;
using System.Windows.Controls;

namespace AllLaunchWPF
{
    /// <summary>
    /// Interaction logic for LaunchListPage.xaml
    /// </summary>
    public partial class LaunchListPage : Page
    {
        public LaunchListPage()
        {
            InitializeComponent();

            this.DataContext = new LaunchListPageViewModel();
        }
    }
}
