using Keysight.Ccl.Wsl.UI;
using MainApplication.WPF_MVVM._6._API.Rest_API.ViewModel;
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

namespace MainApplication.WPF_MVVM._6._API.Rest_API.View
{
    /// <summary>
    /// Interaction logic for UserMain.xaml
    /// </summary>
    public partial class UserMain : WslDialog
    {
        private readonly UserViewModel _viewModel;
        public UserMain()
        {
            InitializeComponent();
            DataContext = new UserViewModel();
        }
    }
}
