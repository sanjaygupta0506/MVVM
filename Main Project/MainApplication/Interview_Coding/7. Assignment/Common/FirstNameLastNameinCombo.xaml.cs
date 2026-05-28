using Keysight.Ccl.Wsl.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MainApplication.WPF_Assignment.Common
{
    /// <summary>
    /// Interaction logic for FirstNameLastNameinCombo.xaml
    /// </summary>
    public partial class FirstNameLastNameinCombo : WslDialog
    {
        public FirstNameLastNameinCombo()
        {
            InitializeComponent();
            ComboViewModel comboViewModel = new ComboViewModel();
            this.DataContext = comboViewModel;
        }
    }

    public class Model
    {
        //Model for UI
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class ComboViewModel : INotifyPropertyChanged
    {

        public ComboViewModel()
        {
            //Add 2 dummy Entry for Combo
            ComboCollection.Add(new Model() { FirstName = "Mickey", LastName = "Mouse" });
            ComboCollection.Add(new Model() { FirstName = "Donald", LastName = "Duck" });
        }


        private ObservableCollection<Model> comboCollection = new ObservableCollection<Model>();
        //Collection to bind to Combobox
        public ObservableCollection<Model> ComboCollection
        {
            get { return comboCollection; }
            set { comboCollection = value; OnPropertyChanged("ComboCollection"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
