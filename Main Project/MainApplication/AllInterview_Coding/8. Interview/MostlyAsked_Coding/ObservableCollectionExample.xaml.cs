using Keysight.Ccl.Wsl.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MainApplication.AllInterview_Coding
{
    /// <summary>
    /// Interaction logic for ObservableCollectionExample.xaml
    /// </summary>
    public partial class ObservableCollectionExample : WslDialog
    {
        public ObservableCollection<string> Employees { get; set; }
        public ObservableCollectionExample()
        {
            InitializeComponent();

            Employees = new ObservableCollection<string>
            {
                "Sanjay Gupta",
                "Kanchan Gupta",
                "Devansh Gupta",
                "Divyanshi Gupta"
            };
            DataContext = this;
        }
    }
}
