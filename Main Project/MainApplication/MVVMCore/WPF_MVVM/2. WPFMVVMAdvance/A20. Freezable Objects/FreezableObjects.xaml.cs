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

namespace MainApplication.WPF_MVVM._2._WPFMVVMAdvance.Freezable_Objects
{
    /// <summary>
    /// Interaction logic for FreezableObjects.xaml
    /// </summary>
    public partial class FreezableObjects : WslDialog
    {
        public FreezableObjects()
        {
            InitializeComponent();
        }

        private void WslDialog_Loaded(object sender, RoutedEventArgs e)
        {
            RadialGradientBrush radialBrush = new RadialGradientBrush();
            radialBrush.GradientStops.Add(new GradientStop(Colors.Red, 0.2));
            radialBrush.GradientStops.Add(new GradientStop(Colors.White, 0.9));

            MyText.Background = radialBrush;

            if (radialBrush.CanFreeze)
                radialBrush.Freeze();

            if (radialBrush.IsFrozen)
            {
                radialBrush = radialBrush.Clone();
                radialBrush.GradientStops.Add(new GradientStop(Colors.Blue, 1));
                MyText.Background = radialBrush;
            }
        }
    }
}
