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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainApplication.WPF_MVVM._2._WPFMVVMAdvance.B2.UserControlsVsCustomControl.Common
{
    /// <summary>
    /// Interaction logic for ResidentialDetails.xaml
    /// </summary>
    public partial class ResidentialDetails : UserControl
    {
        public ResidentialDetails()
        {
            InitializeComponent();
        }

        private void x_Add_Click(object sender, RoutedEventArgs e)
        {
            x_Display.Text = "Name : " + txt1.Text + " | " + "City : " + txt2.Text;
        }
    }
}
