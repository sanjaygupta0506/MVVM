using Keysight.Ccl.Wsl.UI;
using MVVMCore;
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

namespace MainApplication.WPF_MVVM.WPFMVVMPattern
{
    /// <summary>
    /// Interaction logic for SamplesMVVM.xaml
    /// </summary>
    public partial class SamplesMVVM : WslDialog
    {
        public SamplesMVVM()
        {
            InitializeComponent();
            //this.DataContext = new SampleMVVMModel();
            this.DataContext = new SampleMVVMViewModel(new SampleMVVMModel());
            
           

        }
    }
}
