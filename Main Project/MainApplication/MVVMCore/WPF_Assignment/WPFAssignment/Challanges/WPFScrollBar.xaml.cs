using Keysight.Ccl.Wsl.UI;
using Keysight.Ccl.Wsl.UI.Managers;
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

namespace MVVMCore.Challanges
{
    /// <summary>
    /// Interaction logic for WPFScrollBar.xaml
    /// </summary>
    public partial class WPFScrollBar : WslDialog
    {
        public WPFScrollBar()
        {
            InitializeComponent();
            SkinManager.Instance.SkinChanged += Instance_SkinChanged;
        }

        private void Instance_SkinChanged(object sender, SkinChangedEventArgs e)
        {
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.Resources["NormalBrush"] = ThemeMgr.ThemeScrollBarNormalBackgroundColour;
            this.Resources["HoverBrush"] = ThemeMgr.ThemeScrollBarHoverBackgroundColour;
            this.Resources["ActiveBrush"] = ThemeMgr.ThemeScrollBarActiveBackgroundColour;
            this.Resources["ReverseBrush"] = ThemeMgr.ThemeScrollBarReverseBackgroundColour;
        }
    }
}
