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

namespace MainApplication.WPF_MVVM.WPFMVVMBasic.RoutedEvents
{
    /// <summary>
    /// Interaction logic for RoutedEventsExample.xaml
    /// </summary>
    public partial class RoutedEventsExample : WslDialog
    {
        public RoutedEventsExample()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "Button is Clicked";
        }

        private void StackPanel_Click(object sender, MouseButtonEventArgs e)
        {
            txt2.Text = "Only the Click event is bubbled to Stack Panel";
            e.Handled = true;
        }

        private void Window_Click(object sender, MouseButtonEventArgs e)
        {
            txt3.Text = "Only the Click event is bubbled to Window";
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am the outer button");
        }

        private void outerEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("I am the green ellipse");
            e.Handled = true;
        }

        private void InnerButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am the inner button");
            e.Handled = true;
        }
    }
}
