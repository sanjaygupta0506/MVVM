using Keysight.Ccl.Wsl.UI;
using MainApplication.WPF_MVVM._6._API.Rest_API.Model;
using MainApplication.WPF_MVVM._6._API.Rest_API.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
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

namespace MainApplication.WPF_MVVM._6._API.Rest_API
{

    /// <summary>
    /// Interaction logic for WPFRestAPI.xaml
    /// </summary>
    public partial class WPFRestAPI : WslDialog
    {
        private readonly PostViewModel _viewModel;

        public WPFRestAPI()
        {
            InitializeComponent();
            DataContext = new PostViewModel();
        }

    }  
        

}
