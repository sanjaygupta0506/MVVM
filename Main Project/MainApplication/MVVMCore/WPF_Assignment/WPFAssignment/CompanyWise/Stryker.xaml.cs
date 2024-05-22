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

namespace MainApplication.WPF_Assignment.CompanyWise
{
    /// <summary>
    /// Interaction logic for Stryker.xaml
    /// </summary>
    public partial class Stryker : Window
    {
        public Stryker()
        {
            InitializeComponent();
            List<Employee> employees = new List<Employee>()
            {
                new Employee{FName="Sanjay",LName="Gupta",Age=40, Gender="M"},
                new Employee{FName="Sanjay1",LName="Gupta1",Age=41, Gender="M"},
                new Employee{FName="Sanjay2",LName="Gupta2",Age=43, Gender="M"},
                new Employee{FName="Sanjay3",LName="Gupta3",Age=44, Gender="M"},

            };

            x_Main.ItemsSource = employees;

        }
    }

    public class Employee
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }

        public string Gender { get; set; }
    }
}
