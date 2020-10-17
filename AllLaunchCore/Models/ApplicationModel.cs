namespace AllLaunchCore
{
    /// <summary>
    /// Represents the data about an application
    /// <summary>
    public class ApplicationModel
    {
        #region Public properties

        /// <summary>
        /// The name of the application
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The path to the application's executable file
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// The launch arguments for the application
        /// </summary>
        public string Arguments { get; set; }

        #endregion
    }
}
