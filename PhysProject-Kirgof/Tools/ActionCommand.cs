using System;
using System.Windows.Input;

namespace PhysProject_Kirgof.Tools
{
    public class ActionCommand : ICommand
    {
        public ActionCommand(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action();
        }

        private readonly Action _action;
    }
}