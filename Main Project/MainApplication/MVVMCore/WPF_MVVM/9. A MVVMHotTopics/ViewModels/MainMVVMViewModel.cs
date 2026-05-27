using CommunityToolkit.Mvvm.Input;
using MainApplication.WPF_MVVM._1._WPFMVVMBasic.RelativeSource;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace MainApplication.WPF_MVVM._9._A_MVVMHotTopics.ViewModels
{
    public class MainMVVMViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> MyItems { get; set; }
        
        public MainMVVMViewModel()
        {
            SubmitCommand = new RelayCommand(Submit);
            MyItems = new ObservableCollection<string>();
            MyItems.Add("Sanjay");
            MyItems.Add("Kanchan");
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(nameof(Name));  }
        }
        //--------------------------------------------------------
        public ICommand SubmitCommand { get; }

        private void Submit()
        {
            MessageBox.Show($"Hello {Name}");
        }

        //----------------------------------------------------------

        

        //------------------------------------------------------------
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        
    }
}
