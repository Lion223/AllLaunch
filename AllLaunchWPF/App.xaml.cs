using AllLaunchCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AllLaunchWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Application setup
            ApplicationSetup();

            // Default implementation of the method
            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }

        /// <summary>
        /// Application configuration
        /// </summary>
        private void ApplicationSetup()
        {
            // IoC setup that precedes the application setup
            IoCContainer.Setup();

            // Bind the UI manager
            IoCContainer.Kernel.Bind<IUIManager>().ToConstant(new UIManager());
        }
    }
}
