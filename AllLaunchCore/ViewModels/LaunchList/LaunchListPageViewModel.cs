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
        /// <summary>
        /// Sort bar items visibility toggles
        /// </summary>
        public bool NameSortMenuVisible { get; set; }
        public bool StateSortMenuVisible { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The sort bar commands
        /// </summary>
        public ICommand NameSortCommand { get; set; }
        public ICommand StateSortCommand { get; set; }

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
            // Initialize commands for the sort bar
            NameSortCommand = new Command(NameSortButton);

            // Initialize commands for the menu
            AddCommand = new Command(Add);
            UpdateCommand = new Command(Update);
            RemoveCommand = new Command(Remove);
            LaunchCommand = new Command(Launch);
            SaveCommand = new Command(Save);
            LoadCommand = new Command(Load);
            ArgumentsCommand = new Command(Arguments);
        }

        #endregion

        #region Command methods

        /// <summary>
        /// When the name sort button clicked, toggle the menu
        /// </summary>
        public void NameSortButton()
        {
            NameSortMenuVisible ^= true;
        }

        /// <summary>
        /// When the add button clicked, the add window appears
        /// </summary>
        public void Add()
        {
            // Call the add box dialog
            IoCContainer.UI.ShowAdd(new AddBoxDialogViewModel
            {
                Application = new ApplicationModel
                {
                    Name = "App :)",
                    Path = @"Tower:\Motherboard\SSD\AppFolder\App.exe",
                    Arguments = ":) ^_^ :D"
                }
            });
        }
        /// <summary>
        /// When the update button clicked, the update window appears
        /// </summary>
        public void Update()
        {
            // TODO: the update box dialog
            throw new NotImplementedException();
        }
        /// <summary>
        /// When the remove button clicked, the remove window appears
        /// </summary>
        public void Remove()
        {
            // TODO: the remove box dialog
            throw new NotImplementedException();
        }
        /// <summary>
        /// When the launch button clicked, a launch process is started
        /// </summary>
        public void Launch()
        {
            // TODO: the launch process
            throw new NotImplementedException();
        }
        /// <summary>
        /// When the save button clicked, the save window appears
        /// </summary>
        public void Save()
        {
            // TODO: the save box dialog
            throw new NotImplementedException();
        }
        /// <summary>
        /// When the load button clicked, the load window appears
        /// </summary>
        public void Load()
        {
            // TODO: the load box dialog
            throw new NotImplementedException();
        }
        /// <summary>
        /// When the arguments button clicked, the arguments window appears
        /// </summary>
        public void Arguments()
        {
            // TODO: the arguments box dialog
            IoCContainer.UI.ShowMessage(new MessageBoxDialogViewModel
            {
                Message = "Remember to drink water every once in a while :)",
                OKText = "OK"
            });
        }

        #endregion
    }
}
