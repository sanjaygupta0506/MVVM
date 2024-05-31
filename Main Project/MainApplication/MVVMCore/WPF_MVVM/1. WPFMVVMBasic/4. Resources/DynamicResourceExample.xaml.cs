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

namespace MainApplication.WPF_MVVM.WPFMVVMBasic.Resources
{
    /// <summary>
    /// Interaction logic for ResourceExample.xaml
    /// </summary>
    public partial class DynamicResourceExample : WslDialog
    {
        public DynamicResourceExample()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["BgDynamicResource"] = new SolidColorBrush(Colors.Red);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["BgDynamicResource"] = new SolidColorBrush(Colors.Blue);
        }
    }
}
