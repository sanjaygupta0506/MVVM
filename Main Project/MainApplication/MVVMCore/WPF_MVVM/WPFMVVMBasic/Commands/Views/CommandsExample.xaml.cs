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

namespace MVVMCore.Commands
{
    /// <summary>
    /// Interaction logic for CommandsExample.xaml
    /// </summary>
    public partial class CommandsExample : Window
    {
        public CommandsExample()
        {
            InitializeComponent();
            #region Common - Theme & Location

            this.Background = ThemeMgr.ThemeBackgroundColour;
            this.Foreground = ThemeMgr.ThemeForgroundColour;
            Color color = new Color();
            color = Color.FromArgb(26, 188, 194, 204);

            #endregion
        }

        private void pnlMainGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
        }
    }
}
