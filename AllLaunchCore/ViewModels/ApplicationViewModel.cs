namespace AllLaunchCore
{
    /// <summary>
    /// A view model that serves as an application navigator
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        #region Public properties

        /// <summary>
        /// Current page of the application
        /// Which is by default the launch list page
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.LaunchListPage;

        #endregion
    }
}
