using MainApplication.WPF_MVVM.WPFMVVMBasic.Commands.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MainApplication.WPF_MVVM.WPFMVVMBasic.Commands.ViewModel
{
    public class PersonViewModel
    {
        private IList<PersonModel> _personList;
        public PersonViewModel()
        {
            _personList = new List<PersonModel>()
        {
            new PersonModel(){Name="Prabhat", Address="Bangalore"},
            new PersonModel(){Name="John", Address="Delhi"}
        };
        }
        public IList<PersonModel> Persons
        {
            get { return _personList; }
            set { _personList = value; }
        }
        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }
    }
    class Updater : ICommand
    {
        #region ICommand Members  

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            //Your Code  
        }
        #endregion
    }
}
