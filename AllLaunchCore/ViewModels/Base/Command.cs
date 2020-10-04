using System;
using System.Windows.Input;

namespace AllLaunchCore
{
    /// <summary>
    /// Command interface implementation
    /// </summary>
    public class Command : ICommand
    {
        private Action _action;

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public Command(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
