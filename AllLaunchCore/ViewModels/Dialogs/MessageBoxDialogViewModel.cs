namespace AllLaunchCore
{ 
    /// <summary>
    /// A view model for a message box dialog
    /// </summary>
    public class MessageBoxDialogViewModel : BaseDialogViewModel
    {
        #region Public properties

        /// <summary>
        /// The content of the dialog
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// The content of the "OK" button
        /// </summary>
        public string OKText { get; set; }     

        #endregion
    }
}
