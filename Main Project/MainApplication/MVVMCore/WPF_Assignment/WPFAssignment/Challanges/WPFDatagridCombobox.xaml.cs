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

namespace MVVMCore.Challanges
{
    /// <summary>
    /// Interaction logic for WPFDatagridCombobox.xaml
    /// </summary>
    public partial class WPFDatagridCombobox : WslDialog
    {
        public WPFDatagridCombobox()
        {
            InitializeComponent();

            //DataGridComboBoxColumn dataGridComboBoxColumn = new DataGridComboBoxColumn();
            //dataGridComboBoxColumn.ItemsSource = StatusList.TicketInfo.();

        }
        //enum MyEnum
        //{
        //    a = 1,
        //    b = 2
        //}

        private void X_tXPreset8G_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void X_tXPreset32G_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void X_tXPreset16G_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void X_dgEqualizationPHYControlTXLanes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    public class StatusList : List<string>
    {
        public StatusList()
        {
            this.Add("Assigned");
            this.Add("Closed");
            this.Add("In Progress");
            this.Add("Open");
            this.Add("Resolved");
        }

        public class TicketInfo
        {
            public string Subject { get; set; }
            public string Status { get; set; }
            public string RaisedBy { get; set; }
        }
    }
}
