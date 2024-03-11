using MVVMCore.MVVMCommads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMCore.Model
{
    public class CommandsModel
    {
        public ICommand myCommand { get; set; }

        public CommandsModel()
        {
            myCommand = new MVVMCommand(ExecuteMethod, canExecuteMethod);
        }

        private bool canExecuteMethod(object parameter)
        {
            return true;
        }

        private void ExecuteMethod(object parameter)
        {
            //UpdateCommand = new MVVMCommand(ExecuteMethod, canExecuteMethod);
            MessageBox.Show("This is not code behind code");
        }
    }
}
