using Keysight.Ccl.Wsl.UI;
using MainApplication;
using MainApplication.CommonUtils;
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

namespace MVVMCore.DataContext
{
    /// <summary>
    /// Interaction logic for DataContextExample.xaml
    /// </summary>
    public partial class DataContextExample : WslDialog
    {
        public DataContextExample()
        {
            InitializeComponent();
            Person person = new Person()
            {
                FirstName = "Sanjay",
                LastName = "Gupta",
                Age = 40
            };
            this.DataContext = person;

            #region Common - Theme & Location

            this.Background = ThemeMgr.ThemeBackgroundColour;

            #endregion

        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
