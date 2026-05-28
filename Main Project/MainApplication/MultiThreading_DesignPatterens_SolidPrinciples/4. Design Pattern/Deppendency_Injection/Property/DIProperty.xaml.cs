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

namespace MainApplication.WPF_MVVM._4._Design_Pattern.Deppendency_Injection.Property
{
    /// <summary>
    /// Interaction logic for DIProperty.xaml
    /// </summary>
    public partial class DIProperty : WslDialog
    {
        public DIProperty()
        {
            InitializeComponent();
        }

        private void x_dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeeBAL employeeBAL = new EmployeeBAL();
            employeeBAL.employeeDataObject = new EmployeeDAL();

            List<Employee> ListEmployee = employeeBAL.GetAllEmployees();
            x_dataGrid.ItemsSource = ListEmployee;
        }
    }
}
