using System.Windows;
using System.Windows.Controls;

namespace AllLaunchWPF
{
    /// <summary>
    /// A view model for the dialog window
    /// </summary>
    public class DialogWindowViewModel : MainWindowViewModel
    {
        #region Private members

        #endregion

        #region Public properties

        /// <summary>
        /// The title of the dialog window
        /// </summary>
        public string Title { get; set; } 
        /// <summary>
        /// The property to toggle the title appearance
        /// </summary>
        public Visibility TitleVisibility { get; set; }
        /// <summary>
        /// The content to host inside of the dialog window
        /// </summary>
        public Control Content { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor that calls for the parent contructor and passes a window object
        /// </summary>
        /// <param name="window">The window object</param>
        public DialogWindowViewModel(Window window) : base(window) { }

        #endregion
    }
}
