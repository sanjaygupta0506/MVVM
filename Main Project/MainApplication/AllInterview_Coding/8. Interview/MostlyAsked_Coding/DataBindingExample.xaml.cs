using Keysight.Ccl.Wsl.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MainApplication.AllInterview_Coding
{
    /// <summary>
    /// Interaction logic for DataBindingExample.xaml
    /// </summary>
    public partial class DataBindingExample : WslDialog, INotifyPropertyChanged
    {
        private string _username;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public DataBindingExample()
        {
            _username = "Sanjay";
            //InitializeComponent();
            
            DataContext = this;
        }

        public string UserName
        {
            get { return _username; }
            set 
            { 
                _username = value; 
                OnPropertyChanged(nameof(UserName));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
