using AllLaunchCore;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AllLaunchWPF
{
    /// <summary>
    /// The base class for the content of a <see cref="DialogWindow"/>
    /// </summary>
    public class BaseDialogUserControl : UserControl
    {
        #region Private members

        /// <summary>
        /// The dialog window this class will be contained within
        /// </summary>
        private DialogWindow _dialogWindow;

        #endregion

        #region Public commands

        /// <summary>
        /// Closes the dialog
        /// </summary>
        public ICommand CloseCommand { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseDialogUserControl()
        {
            // Create a new dialog
            _dialogWindow = new DialogWindow();
            _dialogWindow.ViewModel = new DialogWindowViewModel(_dialogWindow);

            // Close command
            CloseCommand = new Command(() => _dialogWindow.Close());
        }

        #endregion

        #region Dialog output methods

        /// <summary>
        /// Display a dialog
        /// </summary>
        /// <param name="viewModel">The view model</param>
        /// <typeparam name="T">The view model type for this control</typeparam>
        /// <returns></returns>
        public Task ShowDialog<T>(T viewModel)
            where T : BaseDialogViewModel
        {
            // Check whenever the dialog is closed
            var tcs = new TaskCompletionSource<bool>();

            Application.Current.Dispatcher.Invoke(() =>
            {
                try
                {
                    // Set the dialog to match the dialog window's view model's properties
                    _dialogWindow.ViewModel.Title = viewModel.Title;
                    _dialogWindow.ViewModel.TitleVisibility = string.IsNullOrEmpty(viewModel.Title) ? Visibility.Collapsed : Visibility.Visible;

                    // Set the content to the dialog window
                    _dialogWindow.ViewModel.Content = this;

                    // Bind the context of the control to the view model
                    DataContext = viewModel;

                    // Show the dialog window
                    _dialogWindow.ShowDialog();
                }
                finally
                {
                    // Dialog is closed
                    tcs.TrySetResult(true);
                }
            });

            return tcs.Task;
        } 

        #endregion
    }
}
