using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Module4__Assignment3.Commands
{
    class RelayCommand : ICommand
    {
        Action _handler;
        public RelayCommand(Action h)
        {
            _handler = h;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            bool action = false;

            if (_handler != null)
            {
                action = true;
            }

            return action;
        }

        public void Execute(object parameter)
        {
            _handler();
        }
    }
}
