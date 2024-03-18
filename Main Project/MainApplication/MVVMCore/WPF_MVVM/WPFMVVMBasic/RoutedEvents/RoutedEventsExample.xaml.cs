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
    public partial class RoutedEventsExample : Window
    {
        public RoutedEventsExample()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("I am outer button");
        }

        private void overEllipse_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("I am green ellipse");
        }

        private void InnerButton_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("I am inner button");
            e.Handled = true;
        }

        private void btnClickMe_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("I am outer button for tunneling event");
        }

       

        private void Canvas_PreviewMouseMove(object sender, MouseEventArgs e)
        {

        }

        private void InnerButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("I am inner button for tunneling event");
        }

        private void InnerButtonN_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am inner button");
            e.Handled = true;
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am Outer N button");
        }
    }
}
