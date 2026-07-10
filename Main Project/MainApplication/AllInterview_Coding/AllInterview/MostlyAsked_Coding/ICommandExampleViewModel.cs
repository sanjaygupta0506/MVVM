using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AllInterview_Coding._8._Interview.MostlyAsked_Coding
{
    public class ICommandExampleViewModel
    {
        public ICommand MyCommand { get; }

        public ICommandExampleViewModel()
        {
            MyCommand =
                new MainApplication.AllInterview_Coding.Comman.RelayCommand(ShowMessage);
        }

        private void ShowMessage()
        {
            MessageBox.Show("Hello Sanjay");
        }
    }
}
