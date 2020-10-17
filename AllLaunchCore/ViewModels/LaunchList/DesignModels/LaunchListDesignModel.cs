using System.Collections.Generic;

namespace AllLaunchCore
{
    /// <summary>
    /// A DesignModel for a <see cref="LaunchListDesignModel"/> 
    /// </summary>
    public class LaunchListDesignModel : LaunchListViewModel
    {
        #region Singleton

        /// <summary>
        /// Singleton implementation
        /// </summary>
        public static LaunchListDesignModel Instance { get; } = new LaunchListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Dummy data initialization
        /// </summary>
        public LaunchListDesignModel()
        {
            // Mock data
            Items = new List<LaunchListItemViewModel>
            {
                new LaunchListItemViewModel
                {
                    Name = "AllLaunch",
                    Arguments = "-n -q -w",
                    State = ApplicationState.Running
                },
                new LaunchListItemViewModel
                {
                    Name = "Visual Studio 2019",
                    Arguments = "",
                    State = ApplicationState.Inactive
                },
                new LaunchListItemViewModel
                {
                    Name = "Figma",
                    Arguments = "-l",
                    State = ApplicationState.Error,
                    IsSelected = true
                },
                new LaunchListItemViewModel
                {
                    Name = "Spotify",
                    Arguments = "",
                    State = ApplicationState.Running
                },
                new LaunchListItemViewModel
                {
                    Name = "Telegram",
                    Arguments = "",
                    State = ApplicationState.Running
                },
                new LaunchListItemViewModel
                {
                    Name = "Twitch",
                    Arguments = "-n",
                    State = ApplicationState.Inactive
                },
                new LaunchListItemViewModel
                {
                    Name = "Google Chrome",
                    Arguments = "",
                    State = ApplicationState.Error
                },
                new LaunchListItemViewModel
                {
                    Name = "Discord",
                    Arguments = "",
                    State = ApplicationState.Running,
                    IsSelected = true
                },
                new LaunchListItemViewModel
                {
                    Name = "Visual Studio Code",
                    Arguments = "",
                    State = ApplicationState.Running
                },
                new LaunchListItemViewModel
                {
                    Name = "Blender",
                    Arguments = "",
                    State = ApplicationState.Inactive
                },
                new LaunchListItemViewModel
                {
                    Name = "SumatraPDF",
                    Arguments = "",
                    State = ApplicationState.Error
                },
                new LaunchListItemViewModel
                {
                    Name = "Git Bash",
                    Arguments = "",
                    State = ApplicationState.Inactive
                },
            };
        }

        #endregion
    }
}
