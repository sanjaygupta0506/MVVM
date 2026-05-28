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

namespace MainApplication.WPF_MVVM._6._API.Web_API
{
    /// <summary>
    /// Interaction logic for WPFMVVMWebAPI.xaml
    /// </summary>
    public partial class WPFMVVMWebAPI : WslDialog
    {
        public WPFMVVMWebAPI()
        {
            InitializeComponent();
            DataContext = new WPFMVVMWebAPIViewModel();
        }
    }
}
