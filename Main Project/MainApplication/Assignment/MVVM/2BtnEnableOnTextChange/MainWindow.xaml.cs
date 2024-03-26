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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel viewModel = new MainApplication.ViewModel();
            this.DataContext = viewModel;
        }
    }
    public class ViewModel : INotifyPropertyChanged
    {

        private string textData;
        //UI Binding for Text box
        public string TextData
        {
            get { return textData; }
            set
            {
                textData = value;
                OnPropertyChanged("TextData");
                //enable disable button on string length
                if (textData.Length > 0)
                {
                    IsSubmitButtonEnabled = true;
                }
                else
                    IsSubmitButtonEnabled = false;
            }
        }

        

        private bool isSubmitButtonEnabled;
        //prop to enable disable Button,binded to UI
        public bool IsSubmitButtonEnabled
        {
            get { return isSubmitButtonEnabled; }
            set { isSubmitButtonEnabled = value; OnPropertyChanged("IsSubmitButtonEnabled"); }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
