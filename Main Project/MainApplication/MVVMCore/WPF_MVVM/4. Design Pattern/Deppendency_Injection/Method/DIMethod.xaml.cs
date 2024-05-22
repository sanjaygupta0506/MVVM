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

namespace MainApplication.WPF_MVVM._4._Design_Pattern.Deppendency_Injection.Method
{
    /// <summary>
    /// Interaction logic for DIMethod.xaml
    /// </summary>
    public partial class DIMethod : WslDialog
    {
        public DIMethod()
        {
            InitializeComponent();
        }

        private void x_dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeeBAL employeeBL = new EmployeeBAL();
            //Call to GetAllEmployees method with proper object.            
            List<Employee> ListEmployee = employeeBL.GetAllEmployees(new EmployeeDAL());
            x_dataGrid.ItemsSource = ListEmployee;
        }
    }
}
