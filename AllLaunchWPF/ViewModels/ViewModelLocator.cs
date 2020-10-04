using AllLaunchCore;

namespace AllLaunchWPF
{
    /// <summary>
    /// Receives a view model from the IoC container for a binding in XAML files
    /// </summary>
    public class ViewModelLocator
    {
        #region Public properties

        /// <summary>
        /// Singleton instance of the locator
        /// </summary>
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        /// <summary>
        /// Receive a <see cref="ApplicationViewModel"/> view model from the IoC container 
        /// </summary>
        public static ApplicationViewModel ApplicationViewModel => IoCContainer.Get<ApplicationViewModel>();

        #endregion
    }
}
