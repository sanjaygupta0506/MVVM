using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProgramMain.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _text;
        public PersonViewModel()
        {
            Text = "Hello, Sanjay!";
        }
        

        public string Text
        {
            get { return _text; }
            set 
            { 
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
