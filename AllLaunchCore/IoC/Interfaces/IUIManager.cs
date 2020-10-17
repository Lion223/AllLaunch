using System.Threading.Tasks;

namespace AllLaunchCore
{
    /// <summary>
    /// The UI manager that handles any UI interaction in the application
    /// </summary>
    public interface IUIManager
    {
        /// <summary>
        /// Display a message box dialog
        /// </summary>
        /// <param name="viewModel">The view model</param>
        /// <returns></returns>
        Task ShowMessage(MessageBoxDialogViewModel viewModel);
        /// <summary>
        /// Display an add box dialog
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        Task ShowAdd(AddBoxDialogViewModel viewModel);
    }
}
