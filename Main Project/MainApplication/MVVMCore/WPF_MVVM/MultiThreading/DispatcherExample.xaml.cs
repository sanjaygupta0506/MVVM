using Keysight.Ccl.Wsl.UI;
using MainApplication.CommonUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace MainApplication.WPF_MVVM.MultiThreading
{
    /// <summary>
    /// Interaction logic for Dispatcher.xaml
    /// </summary>
    public partial class DispatcherExample : WslDialog
    {

        // So, Dispatcher is the best way for updating a WPF UI with a thread.
        public DispatcherExample()
        {
            InitializeComponent();
            Thread thread = new Thread(Update);
            Thread thread1 = new Thread(Update1);
            thread.Start();
            thread1.Start();

            #region Common - Theme & Location
            this.Background = ThemeMgr.ThemeBackgroundColour;
            this.Foreground = ThemeMgr.ThemeForgroundColour;
            #endregion

        }
        private void Update()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            //txtName.Text = "Here is some new text.";
            //this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate ()
            // {
            //     txtName.Text = "Multithreading Dispather Example";
            // });

            //Option 1
            this.Dispatcher.BeginInvoke(new Action(() =>

            {
                txtName.Text = "Sanjay Gupta";
            
            }));

            //Option 2
            //this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate ()

            //{
            //    txtName.Text = "Kanchan Gupta";
            //}

            //);
        }

        private void Update1()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            //txtName.Text = "Here is some new text.";
            //this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate ()
            // {
            //     txtName.Text = "Multithreading Dispather Example";
            // });

            //Option 1
            //this.Dispatcher.BeginInvoke(new Action(() =>

            //{
            //    txtName.Text = "Sanjay Gupta";

            //}));

            //Option 2
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate ()

            {
                txtName1.Text = "Kanchan Gupta";
            }

            );
        }
    }
}
