using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelloMVVM.Commands
{
    class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (CanExecuteFunc == null) return true;
           return  CanExecuteFunc.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            ExecuteAction?.Invoke(parameter);
        }

        public Func<object,bool> CanExecuteFunc { get; set; }

        public Action<object> ExecuteAction { get; set; }
    }
}
