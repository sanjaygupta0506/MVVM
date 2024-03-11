using Keysight.Ccl.Wsl.UI.Managers;
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
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MainApplication;
using MainApplication.CommonUtils;

namespace MVVMCore.Challanges
{
    /// <summary>
    /// Interaction logic for CommonControls.xaml
    /// </summary>
    public partial class CommonControls : Window
    {
        public CommonControls()
        {
            InitializeComponent();
            SkinManager.Instance.SkinChanged += KsWsl_ThemeChanged;

            this.Loaded += CommonControls_Loaded;
        }

        private void CommonControls_Loaded(object sender, RoutedEventArgs e)
        {
            this.Resources.MergedDictionaries.Clear();
            if (ThemeMgr.CurrentTheme.ToLower().Contains("dark"))
            {
                this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("pack://    application:,,,/CommonUtils;component/ResourceDictionaries/SolidColorBrushDark.xaml") });
            }
            else
            {
                this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("pack://    application:,,,/CommonUtils;component/ResourceDictionaries/SolidColorBrushLight.xaml") });
            }
        }

        private void KsWsl_ThemeChanged(object sender, SkinChangedEventArgs e)
        {
            this.Resources.MergedDictionaries.Clear();
            if (ThemeMgr.CurrentTheme.ToLower().Contains("dark"))
            {
                this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("pack://application:,,,CommonUtils;component/ResourceDictionaries/SolidColorBrushDark.xaml") });
            }
            else
            {
                this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("pack://application:,,,/application:,,,CommonUtils;component/ResourceDictionaries/SolidColorBrushLight.xaml") });
            }
        }

        //private void KsWsl_ThemeChanged(object sender, SkinChangedEventArgs e)
        //{
        //    this.Resources.MergedDictionaries.Clear();
        //    if (ThemeMgr.CurrentTheme.ToLower().Contains("dark"))
        //    {
        //        this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("pack://application:,,,CommonUtils;component/ResourceDictionaries/SolidColorBrushDark.xaml") });
        //    }
        //    else
        //    {
        //        this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("pack://application:,,,/application:,,,CommonUtils;component/ResourceDictionaries/SolidColorBrushLight.xaml") });
        //    }
        //}
    }
}
