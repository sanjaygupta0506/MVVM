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

namespace MainApplication.WPF_MVVM._2._WPFMVVMAdvance.B2.UserControlsVsCustomControl
{
    /// <summary>
    /// Interaction logic for WPFCustomControls.xaml
    /// </summary>
    public partial class WPFCustomControls : WslDialog
    {
        public WPFCustomControls()
        {
            InitializeComponent();
        }

        private void customControl_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = "You have just click your custom control";
        }
    }
    
}
