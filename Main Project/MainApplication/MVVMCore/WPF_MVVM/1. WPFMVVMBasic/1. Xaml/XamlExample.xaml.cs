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

namespace MainApplication.WPF_MVVM._1._WPFMVVMBasic.Xaml
{
    /// <summary>
    /// Interaction logic for XamlExample.xaml
    /// </summary>
    public partial class XamlExample : WslDialog
    {
        public XamlExample()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Create the StackPanel 
            StackPanel stackPanel = new StackPanel();
            this.Content = stackPanel;

            // Create the Button 
            Button button = new Button();
            button.Content = "Clicked";
            button.HorizontalAlignment = HorizontalAlignment.Left;
            button.Margin = new Thickness(150);
            button.VerticalAlignment = VerticalAlignment.Top;
            button.Width = 300;
            stackPanel.Children.Add(button);
        }
    }
}
