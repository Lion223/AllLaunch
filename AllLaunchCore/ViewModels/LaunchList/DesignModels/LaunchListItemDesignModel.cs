namespace AllLaunchCore
{
    /// <summary>
    /// A DesignModel for a <see cref="LaunchListItemViewModel"/> 
    /// </summary>
    public class LaunchListItemDesignModel : LaunchListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// Singleton implementation
        /// 
        /// Difference between expression-bodied member and { get; } with initialization: https://gist.github.com/Lion223/08870b1cac6ae0bf0cb4107ed0445dd9 
        /// </summary>
        public static LaunchListItemDesignModel Instance { get; } = new LaunchListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Mock data initialization
        /// </summary>
        public LaunchListItemDesignModel()
        {
            Name = "AllLaunch";
            Arguments = "-n -q -w";
            State = ApplicationState.Running;
        }

        #endregion
    }
}
