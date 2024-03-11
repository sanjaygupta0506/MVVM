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

namespace MainApplication.WPF_MVVM.WPFMVVMBasic.wpf_tutorial.com
{
    /// <summary>
    /// Interaction logic for WPFDemo.xaml
    /// </summary>
    public partial class WPFDemo : Window
    {
        public WPFDemo()
        {
            InitializeComponent();
            //Button btn = new Button();
            //btn.FontWeight = FontWeights.Bold;

            //WrapPanel pnl = new WrapPanel();

            //TextBlock txt = new TextBlock();
            //txt.Text = "Multi";
            //txt.Foreground = Brushes.Blue;
            //pnl.Children.Add(txt);

            //txt = new TextBlock();
            //txt.Text = "Color";
            //txt.Foreground = Brushes.Red;
            //pnl.Children.Add(txt);

            //txt = new TextBlock();
            //txt.Text = "Button";
            //pnl.Children.Add(txt);

            //btn.Content = pnl;
            //pnlMain.Children.Add(btn);
        }

        private void pnlMain_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
        }
    }
}
