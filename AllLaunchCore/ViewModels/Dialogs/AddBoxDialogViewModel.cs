namespace AllLaunchCore
{
    /// <summary>
    /// A view model for a add dialog 
    /// <summary>
    public class AddBoxDialogViewModel : BaseDialogViewModel
    {
        #region Public properties

        /// <summary>
        /// The application content (name, path, arguments)
        /// </summary>
        public ApplicationModel Application { get; set; }
        /// <summary>
        /// The content of the "Add" button
        /// </summary>
        public string AddText { get; set; } = "Add";
        /// <summary>
        /// The content of the "Cancel" button
        /// </summary>
        public string CancelText { get; set; } = "Cancel";
        /// <summary>
        /// The content of the "Browse" button
        /// </summary>
        public string BrowseText { get; set; } = "Browse";

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// <summary>
        public AddBoxDialogViewModel()
        {
            // Set up the title
            Title = "Add Application";
        }

        #endregion
    }
}
