using Keysight.Ccl.Wsl.UI;
using MainApplication.WPF_MVVM._9._A_MVVMHotTopics.ViewModels;
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

namespace MainApplication.WPF_MVVM._9._A_MVVMHotTopics.Views
{
    /// <summary>
    /// Interaction logic for MVVMDemo.xaml
    /// </summary>
    public partial class MVVMDemo : WslDialog
    {
        public MVVMDemo()
        {
            InitializeComponent();
            DataContext = new MainMVVMViewModel();
        }
    }
}
