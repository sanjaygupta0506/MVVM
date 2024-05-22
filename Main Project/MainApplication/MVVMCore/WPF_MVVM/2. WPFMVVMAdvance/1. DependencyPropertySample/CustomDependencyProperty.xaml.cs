using Keysight.Ccl.Wsl.UI;
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
using System.Windows.Threading;

namespace MainApplication.WPF_MVVM.WPFMVVMAdvance.DependencyPropertySample
{
    /// <summary>
    /// Interaction logic for DependencyPropertyE2.xaml
    /// </summary>
    public partial class CustomDependencyProperty : WslDialog
    {
        public CustomDependencyProperty()
        {
            InitializeComponent();
            #region Common - Theme & Location

            this.Background = ThemeMgr.ThemeBackgroundColour;
            this.Foreground = ThemeMgr.ThemeForgroundColour;

            #endregion

            DispatcherTimer dispatcherTimer = new DispatcherTimer(TimeSpan.FromSeconds(1), DispatcherPriority.Normal,
                                                                 delegate
                                                                 {
                                                                     int newvalue = 0;
                                                                     if (Counter == int.MaxValue)
                                                                     {
                                                                         newvalue = 0;
                                                                     }
                                                                     else
                                                                     {
                                                                         newvalue = Counter + 1;
                                                                     }
                                                                     SetValue(CounterProperty, newvalue);
                                                                 }, Dispatcher);
        }

        //Syntax of Working Dependency Property
        public int Counter
        {
            get { return (int)GetValue(CounterProperty); }
            set { SetValue(CounterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Counter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CounterProperty =
            DependencyProperty.Register("Counter", typeof(int), typeof(CustomDependencyProperty), new PropertyMetadata(10));
    }
}
