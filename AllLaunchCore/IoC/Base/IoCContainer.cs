using Ninject;

namespace AllLaunchCore
{
    /// <summary>
    /// The IoC container for the application
    /// </summary>
    public static class IoCContainer
    {
        #region Public properties

        /// <summary>
        /// The kernel for the IoC container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        /// <summary>
        /// Shortcut to access the <see cref="IUIManager"/>
        /// </summary>
        public static IUIManager UI => Get<IUIManager>();

        #endregion

        #region Setup

        /// <summary>
        /// Sets up the IoC container, and binds reqiured information
        /// Needs to be run in first order, to ensure every service will be available 
        /// </summary>
        public static void Setup()
        {
            // Bind all required view models
            BindViewModels();
        }

        /// <summary>
        /// Binds all singleton view models
        /// </summary>
        private static void BindViewModels()
        {
            // Bind to a single instance of Application view model
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
        }

        #endregion

        /// <summary>
        /// Receice a service from the IoC container
        /// </summary>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}
