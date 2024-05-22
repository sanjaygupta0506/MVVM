using Keysight.Ccl.Wsl.UI;
using System;
using System.Collections.Generic;
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

namespace MainApplication.WPF_MVVM.WPFMVVMBasic.DataBindings
{
    /// <summary>
    /// Interaction logic for Binding_OneWay.xaml
    /// </summary>
    public partial class Binding_OneWay : WslDialog
    {
        Person person = new Person { Name = "Sanjay", Age = 36 };
        public Binding_OneWay()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            string message = person.Name + " is " + person.Age;
            MessageBox.Show(message);
        }
    }

    public class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private float age;
        public float Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
    }
