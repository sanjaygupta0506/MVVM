using Keysight.Ccl.Wsl.UI;
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

namespace MainApplication.WPF_MVVM.MultiThreading
{
    /// <summary>
    /// Interaction logic for SingleThread.xaml
    /// </summary>
    public partial class SingleThread : WslDialog
    {
        public SingleThread()
        {
            InitializeComponent();
            Thread t = new Thread(Worker);

            // start the thread
            t.Start();

            // do some other work in the main thread
            for (int i = 0; i < 10; i++)
            {
                lblSingleThread.Content = ("Main thread doing some work");
                Thread.Sleep(100);
            }

            // wait for the worker thread to complete
            t.Join();

            lblSingleThread.Content = ("Done");
        }

        void Worker()
        {
            for (int i = 0; i < 10; i++)
            {
                //lblSingleThread.Content = "Worker thread doing some work";
                Thread.Sleep(100);
            }
        }

        private async void btnSingleThread_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(Worker);
        }
    }

}
