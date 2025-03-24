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
using WPF_MVVM.ViewModel;

namespace WPF_MVVM.View
{
    /// <summary>
    /// Interaction logic for TwoWayBindingExample.xaml
    /// </summary>
    public partial class TwoWayBinding : WslDialog
    {
        public TwoWayBinding()
        {
            InitializeComponent();
            this.DataContext = new PersonViewModel();
        }
    }
}
