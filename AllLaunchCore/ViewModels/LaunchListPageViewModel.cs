using System;
using System.Windows.Input;

namespace AllLaunchCore
{
    /// <summary>
    /// A view model for a default frame
    /// </summary>
    public class LaunchListPageViewModel : BaseViewModel
    {
        #region Public properties

        /// <summary>
        /// Minimal size of the frame
        /// </summary>
        public double MinHeight { get; set; } = 452;
        public double MinWidth { get; set; } = 396;
        /// <summary>
        /// The launch list menu height
        /// </summary>
        public double LaunchListMenuBarHeight { get; set; } = 48;

        #endregion

        #region Commands

        /// <summary>
        /// The launch menu commands
        /// </summary>
        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand LaunchCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand LoadCommand { get; set; }
        public ICommand ArgumentsCommand { get; set; }

        #endregion

        #region Constructor

        public LaunchListPageViewModel()
        {
            // Initialize commands for the menu
            AddCommand = new Command(() => throw new NotImplementedException());
            UpdateCommand = new Command(() => throw new NotImplementedException());
            RemoveCommand = new Command(() => throw new NotImplementedException());
            LaunchCommand = new Command(() => throw new NotImplementedException());
            SaveCommand = new Command(() => throw new NotImplementedException());
            LoadCommand = new Command(() => throw new NotImplementedException());
            ArgumentsCommand = new Command(() => throw new NotImplementedException());
        }

        #endregion
    }
}
