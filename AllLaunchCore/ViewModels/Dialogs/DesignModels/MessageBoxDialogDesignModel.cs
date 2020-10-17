namespace AllLaunchCore
{
    /// <summary>
    /// A design model for a <see cref="MessageBoxDialogViewModel"/>
    /// </summary>
    public class MessageBoxDialogDesignModel : MessageBoxDialogViewModel
    {
        #region Singleton

        /// <summary>
        /// Singleton implementation
        /// </summary>
        public static MessageBoxDialogDesignModel Instance { get; } = new MessageBoxDialogDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Design-time data
        /// </summary>
        public MessageBoxDialogDesignModel()
        {
            Message = "I hope you have a nice day!";
            OKText = ":)";
        }

        #endregion
    }
}
