using MainApplication.WPF_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMCore.Model
{
    public class CommandViewModel
    {
        public ICommand mycommad { get; set; }

        public CommandViewModel()
        {
            mycommad = new CommandModel(ExecuteMethod, canExecuteMethod);
        }

        private bool canExecuteMethod(object parameter)
        {
            return true;
        }
        private void ExecuteMethod(object parameter)
        {
            MessageBox.Show("Command Execute No code behind");
        }
    }
}
