namespace AllLaunchCore
{
    /// <summary>
    /// A view model for each launch list item (app)
    /// </summary>
    public class LaunchListItemViewModel : BaseViewModel
    {
        #region Public properties

        /// <summary>
        /// Application name of the item
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Application arguments (launch options) of the item
        /// </summary>
        public string Arguments { get; set; }
        /// <summary>
        /// Application state of the item
        /// </summary>
        public ApplicationState State { get; set; }
        /// <summary>
        /// Application image of the item
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// If the item is currently selected in a launch list
        /// </summary>
        public bool IsSelected { get; set; }

        #endregion
    }
}
