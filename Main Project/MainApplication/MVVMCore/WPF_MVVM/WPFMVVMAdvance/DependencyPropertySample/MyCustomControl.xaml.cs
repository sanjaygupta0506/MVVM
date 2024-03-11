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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainApplication.WPF_MVVM.WPFMVVMAdvance.DependencyPropertySample
{
    /// <summary>
    /// Interaction logic for MyCustomControl.xaml
    /// </summary>
    public partial class MyCustomControl : UserControl
    {
        public MyCustomControl()
        {
            InitializeComponent();
        }


        public string MyValue
        {
            get { return (string)GetValue(MyValueProperty); }
            set { SetValue(MyValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyValueProperty =
            DependencyProperty.Register("MyValue", typeof(string), typeof(MyCustomControl), new PropertyMetadata("", new PropertyChangedCallback(OnSetTextChanged)));

        private static void OnSetTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MyCustomControl myCustomControl = d as MyCustomControl;
            myCustomControl.OnSetTextChanged(e);
        }

        private void OnSetTextChanged(DependencyPropertyChangedEventArgs e)
        {
            tbTest.Text = e.NewValue.ToString();
        }
    }
}
