using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMCore.MVVMCommads
{
    public class MVVMCommand : ICommand
    {
        #region Delegate Method

        Action<object> executeMethod;
        Func<object, bool> canexecuteMethod;

        #region Constructor

        public MVVMCommand(Action<object> executeMethod, Func<object, bool> canexecuteMethod)
        {
            this.executeMethod = executeMethod;
            this.canexecuteMethod = canexecuteMethod;
        }
        #endregion

        #endregion
      

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
