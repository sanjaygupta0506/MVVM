using MVVMCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MainApplication.WPF_MVVM.WPFMVVMPattern
{
    public class SampleMVVMViewModel : INotifyPropertyChanged
    {
        private SampleMVVMModel _model;
        
        public SampleMVVMViewModel(SampleMVVMModel model)
        {
            AddCommand = new AddNameCommand(this);
            _model = model;
        }

        public string CurrentName
        {
            get { return _model.CurrentName; }
            set
            {
                if (value == _model.CurrentName)
                    return;
                _model.CurrentName = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> AddedNames
        {
            get { return _model.AddedNames; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        class AddNameCommand : ICommand
        {
            SampleMVVMViewModel parent;

            public AddNameCommand(SampleMVVMViewModel parent)
            {
                this.parent = parent;
                parent.PropertyChanged += delegate { CanExecuteChanged?.Invoke(this, EventArgs.Empty); };
            }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter) { return !string.IsNullOrEmpty(parent.CurrentName); }

            public void Execute(object parameter)
            {
                parent.AddedNames.Add(parent.CurrentName); ;
                parent.CurrentName = null;
            }
        }

        public ICommand AddCommand { get; private set; }

      
    }
}
