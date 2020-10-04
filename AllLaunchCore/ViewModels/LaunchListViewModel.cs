using System.Collections.Generic;

namespace AllLaunchCore
{
    /// <summary>
    /// A view model for the launch list
    /// </summary>
    public class LaunchListViewModel : BaseViewModel
    {
        #region Public properties

        /// <summary>
        /// The launch list items for the list
        /// </summary>
        public List<LaunchListItemViewModel> Items { get; set; }

        #endregion
    }
}
