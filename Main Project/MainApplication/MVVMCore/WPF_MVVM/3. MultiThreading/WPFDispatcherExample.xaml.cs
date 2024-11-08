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

namespace MainApplication.WPF_MVVM._3._MultiThreading
{
    /// <summary>
    /// Interaction logic for WPFDispatcherExample.xaml
    /// </summary>
    public partial class WPFDispatcherExample : Window
    {
        public WPFDispatcherExample()
        {
            InitializeComponent();
        }

        private void UpdateUI()
        {
            // Simulate a long-running operation
            Thread.Sleep(TimeSpan.FromSeconds(2));

            // Update UI elements on the UI thread
            Dispatcher.Invoke(() =>
            {
                // Perform UI updates
                LabelStatus.Content = "Operation completed!";
            });
        }

        private void x_Dispather_Click(object sender, RoutedEventArgs e)
        {
            // Start a new thread to perform the operation
            Thread workerThread = new Thread(UpdateUI);
            workerThread.Start();

        }
    }

   

}
