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

namespace MainApplication.WPF_MVVM.WPFMVVMAdvance.AttachedPropertySample
{
    /// <summary>
    /// Interaction logic for AttachedPropertyExample.xaml
    /// </summary>
    public partial class AttachedPropertyExample : WslDialog
    {
        public AttachedPropertyExample()
        {
            InitializeComponent();
        }

        public static string GetButtonTextProperty(DependencyObject obj)
        {
            return (string)obj.GetValue(ButtonTextProperty);
        }

        public static void SetButtonTextProperty(DependencyObject obj, string value)
        {
            obj.SetValue(ButtonTextProperty, value);
        }

        // Using a DependencyPropertyExample as the backing store for MyProperty.  This enables animation, styling, binding, etc...  
        public static readonly DependencyProperty ButtonTextProperty =
            DependencyProperty.RegisterAttached("SetButtonText", typeof(string), typeof(AttachedPropertyExample), new PropertyMetadata());

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            UIElement uIElement = (UIElement)sender;
            MessageBox.Show("Button text is: " + GetButtonTextProperty(uIElement), "Attached Property");
        }
    }
}
