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
            ViewModel vm = new ViewModel();
            this.DataContext = vm;
        }
        public class Model
        {
            public string ButtonName { get; set; }
        }
        public class ViewModel : INotifyPropertyChanged
        {

            public ViewModel()
            {
            //Add few item to list
                NameList.Add(new MainApplication.MainWindow.Model() { ButtonName = "Radio 1" });
                NameList.Add(new MainApplication.MainWindow.Model() { ButtonName = "Radio 2" });
                NameList.Add(new MainApplication.MainWindow.Model() { ButtonName = "Radio 3" });
            }

            private List<Model> nameList = new List<Model>();
            //List for Listbox
            public List<Model> NameList
            {
                get { return nameList; }
                set { nameList = value; OnPropertyChanged("NameList"); }
            }





            public event PropertyChangedEventHandler PropertyChanged;
            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}
