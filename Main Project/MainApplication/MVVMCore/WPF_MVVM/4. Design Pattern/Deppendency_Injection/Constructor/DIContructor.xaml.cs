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

namespace MainApplication.WPF_MVVM._4._Design_Pattern.Deppendency_Injection.Constructor
{
    /// <summary>
    /// Interaction logic for DIContructor.xaml
    /// </summary>
    public partial class DIContructor : WslDialog
    {
        public DIContructor()
        {
            InitializeComponent();
        }

        private void x_dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeeBAL objempBAL = new EmployeeBAL(new EmployeeDAL());
            //List<Employee> listEmp = objempBAL.GetAllEmployess();
            //dgvDI.DataSource = listEmp;
            x_dataGrid.ItemsSource = objempBAL.GetAllEmployess();
        }
    }
}
