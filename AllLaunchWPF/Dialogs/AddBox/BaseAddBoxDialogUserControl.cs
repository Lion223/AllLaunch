using AllLaunchCore;
using System;
using System.Windows.Input;

namespace AllLaunchWPF
{
    /// <summary>
    /// The base class for the <see cref="AddBoxDialogControl"/>
    /// </summary>
    public class BaseAddBoxDialogUserControl : BaseDialogUserControl
    {
        #region Public commands

        /// <summary>
        /// Add the application to the launch list
        /// </summary>
        public ICommand AddCommand { get; private set; }
        /// <summary>
        /// Open the file browser
        /// </summary>
        public ICommand BrowseCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// <summary>
        public BaseAddBoxDialogUserControl() : base() 
        {
            // Create the commands
            AddCommand = new Command(Add);
            BrowseCommand = new Command(Browse);
        }

        #endregion

        #region Command methods

        /// <summary>
        /// Add the application to the launch list
        /// </summary>
        private void Add()
        {
            // TODO: Add the functionality to add an app to the list
            throw new NotImplementedException();
        }
        /// <summary>
        /// Open the file browser
        /// </summary>
        private void Browse()
        {
            // TODO: Add the OFD logic
            throw new NotImplementedException();
        }

        #endregion
    }
}
