using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMCore.Model
{
    public class CommandModel : ICommand
    {
        Action<object> executeMethod;
        Func<object, bool> canExecuteMethod;
        public event EventHandler CanExecuteChanged;

        public CommandModel(Action<object> executeMethod, Func<object, bool> canExecuteMethod)
        {
            this.executeMethod = executeMethod;
            this.canExecuteMethod = canExecuteMethod;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }
    }
}
