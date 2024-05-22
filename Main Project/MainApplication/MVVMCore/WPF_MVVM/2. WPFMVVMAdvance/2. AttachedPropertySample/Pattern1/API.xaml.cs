using MVVMCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace MainApplication.WPF_MVVM._2._WPFMVVMAdvance._2._AttachedPropertySample.Pattern1
{
    /// <summary>
    /// Interaction logic for API.xaml
    /// </summary>
    public partial class API : UserControl
    {
        public API()
        {
            InitializeComponent();
        }

        public static bool GetAllowOnlyString(DependencyObject obj)
        {
            return (bool)obj.GetValue(AllowOnlyStringProperty);
        }
        public static void SetAllowOnlyString(DependencyObject obj, bool value)
        {
            obj.SetValue(AllowOnlyStringProperty, value);
        }

        public static readonly DependencyProperty AllowOnlyStringProperty =
                    DependencyProperty.RegisterAttached("AllowOnlyString", typeof(bool), typeof(App), new PropertyMetadata(false, AllowOnlyString));

        public static void AllowOnlyString(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox)
            {
                TextBox txtObj = (TextBox)d;
                txtObj.TextChanged += (s, arg) =>
                {
                    TextBox txt = s as TextBox;
                    if (!Regex.IsMatch(txt.Text, "^[a-zA-Z]*$"))
                    {
                        txtObj.BorderBrush = Brushes.Red;
                        MessageBox.Show("Only letter allowed!");
                    }
                };
            }
        }
    }
}
