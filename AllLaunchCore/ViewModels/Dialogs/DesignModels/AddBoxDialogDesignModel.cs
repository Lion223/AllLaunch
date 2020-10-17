namespace AllLaunchCore
{
    /// <summary>
    /// A design model for a <see cref="AddBoxDialogViewModel"/>
    /// </summary>
    public class AddBoxDialogDesignModel : AddBoxDialogViewModel
    {
        #region Singleton

        /// <summary>
        /// Singleton implementation
        /// </summary>
        public static AddBoxDialogDesignModel Instance { get; } = new AddBoxDialogDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Design-time data
        /// </summary>
        public AddBoxDialogDesignModel()
        {
            Application = new ApplicationModel
            {
                Name = "AllLaunch",
                Path = @"...\netcoreapp3.1\AllLaunchConsoleUI.exe",
                Arguments = "-n -q -w -t"
            };
        }

        #endregion
    }
}
