using AllLaunchCore;
using System.Threading.Tasks;
using System.Windows;

namespace AllLaunchWPF
{ 
    /// <summary>
    /// The WPF implementation of the <see cref="IUIManager"/>
    /// </summary>
    public class UIManager : IUIManager
    {
        /// <summary>
        /// Display a message box dialog
        /// </summary>
        /// <param name="viewModel">The view model</param>
        /// <returns></returns>
        public Task ShowMessage(MessageBoxDialogViewModel viewModel)
        {
            return new MessageBoxDialogControl().ShowDialog(viewModel);
        }
        /// <summary>
        /// Display an add dialog
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public Task ShowAdd(AddBoxDialogViewModel viewModel)
        {
            return new AddBoxDialogControl().ShowDialog(viewModel);
        }
    }
}
