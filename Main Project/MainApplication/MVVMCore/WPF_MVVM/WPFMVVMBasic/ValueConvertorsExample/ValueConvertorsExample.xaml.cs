using Keysight.Ccl.Wsl.UI;
using MainApplication;
using MainApplication.CommonUtils;
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

namespace MVVMCore.ValueConvertors
{
    /// <summary>
    /// Interaction logic for ValueConvertorsExample.xaml
    /// </summary>
    public partial class ValueConvertorsExample : WslDialog, INotifyPropertyChanged
    {
        private ObservableCollection<Person> person;

        public event PropertyChangedEventHandler PropertyChanged;

        public ValueConvertorsExample()
        {
            InitializeComponent();
            person = new ObservableCollection<Person>()
         {
             new Person(){FirstName="Prabhat",LastName="Kumar"},

             new Person(){FirstName="Smith",LastName="John"}
         };
            lstNames.ItemsSource = person;

            #region Common - Theme & Location

            this.Background = ThemeMgr.ThemeBackgroundColour;

            

            #endregion
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            person.Add(new Person() { FirstName = txtName.Text, LastName = txtAddress.Text });
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
    }
    public class Person
    {
        #region private member 

        private string firstname;
        private string lastname;
        private string fullname;

        #endregion
        public string FirstName
        {
            get { return firstname; }
            set
            {
                if (firstname != value)
                {
                    firstname = value;
                    OnPropertyChanged("FirstName");
                    OnPropertyChanged("FullName");
                }
            }
        }
        public string LastName
        {
            get { return lastname; }
            set
            {
                if (lastname != value)
                {
                    lastname = value;
                    OnPropertyChanged("LastName");
                    OnPropertyChanged("FullName");
                }
            }
        }
        public string FullName
        {
            get { return fullname = firstname + " " + lastname; }
            set
            {
                if (fullname != value)
                {
                    fullname = value;
                }
            }
        }

        public DateTime DateAdded { get; set; }

        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }

}



