using Keysight.Ccl.Wsl.UI;
using System;
using System.Collections;
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

namespace MainApplication.WPF_MVVM.WPFMVVMAdvance.Virtualization
{
    /// <summary>
    /// Interaction logic for VirtulizationExample.xaml
    /// </summary>
    public partial class VirtualizationExample : WslDialog
    {
        public VirtualizationExample()
        {
            InitializeComponent();
        }

        private void LoadDataButton_Click(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = GetDataSet();
        }

        public ArrayList GetDataSet()
        {
            ArrayList items = new ArrayList();
            for (var count = 0; count < 10000; ++count)
            {
                items.Add(string.Format("Item {0}", count));
            }
            return items;
        }
    }
}

