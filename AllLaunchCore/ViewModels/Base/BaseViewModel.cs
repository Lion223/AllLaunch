using PropertyChanged;
using System.ComponentModel;

namespace AllLaunchCore
{
    /// <summary>
    /// Base view model that is using Fody.PropertyChanged interface
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        // Initialize with an empty body to prevent the null check at the expense of a very slight performance penalty
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Notify the listener about property's change
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
