using Keysight.Ccl.Wsl.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MainApplication.WPF_MVVM._1._WPFMVVMBasic.ObservableCollection
{
    /// <summary>
    /// Interaction logic for ObservableCollection_Main.xaml
    /// </summary>
    public partial class ObservableCollection_Main : WslDialog
    {
        private ObservableCollection<Person> person;
        public ObservableCollection_Main()
        {
            InitializeComponent();
            person = new ObservableCollection<Person>()
            {
             new Person(){Name="Prabhat",Address="India"},

             new Person(){Name="Smith",Address="US"}
            };
            lstNames.ItemsSource = person;
        }

        private void btnNames_Click(object sender, RoutedEventArgs e)
        {
            person.Add(new Person() { Name = txtName.Text, Address = txtAddress.Text });
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

}

