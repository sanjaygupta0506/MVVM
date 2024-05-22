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

namespace MainApplication.WPF_MVVM.Design_Pattern.Singletons
{
    /// <summary>
    /// Interaction logic for SingletonDemo.xaml
    /// </summary>
    public partial class SingletonDemo : WslDialog
    {
        public SingletonDemo()
        {
            InitializeComponent();
            GetStateInfo();
        }

        void GetStateInfo()
        {
            ApplicationState applicationState = ApplicationState.GetState();
            applicationState.LoginID = "Sanjay";
            applicationState.RoleId = "Admin";

            ApplicationState applicationState1 = ApplicationState.GetState();
            lbl3.Content = applicationState1.LoginID;
            lbl5.Content = applicationState1.RoleId;
            lbl6.Content = (applicationState == applicationState1).ToString();

        }
    }
}
