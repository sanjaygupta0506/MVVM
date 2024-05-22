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

namespace MVVMCore.DataBindings
{
    /// <summary>
    /// Interaction logic for SampleDataBinding.xaml
    /// </summary>
    public partial class Binding_Main : WslDialog
    {
        Employee employee = new Employee { };
        public Binding_Main()
        {
            InitializeComponent();
            this.DataContext = employee;

            //< !--One Time-- >
             x_MySlider.Value = 50;
            x_MyTxtbox5.Text = x_MySlider.Value.ToString();
        }
    }

    public class Employee
    {
        private string employeeNumber;
        public string EmployeeNumber
        {
            get
            {
                return employeeNumber;
            }
            set
            {
                employeeNumber = value;
            }
        }

        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        private string department;
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
    }
}
