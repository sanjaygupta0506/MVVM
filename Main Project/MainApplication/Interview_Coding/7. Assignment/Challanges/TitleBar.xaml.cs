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

namespace MVVMCore.Challanges
{
    /// <summary>
    /// Interaction logic for DataContextExample.xaml
    /// </summary>
    public partial class TitleBar : WslDialog
    {
        public TitleBar()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            //HeaderIcon.Source = BitmapFrame.Create(new Uri("pack://application:,,,/IconApp.ico", UriKind.RelativeOrAbsolute));
            HeaderTitle.Text = "Title of Window";

        }

        #region ResizeWindows

        bool ResizeInProcess = false;

        private void Resize_Init(object sender, MouseButtonEventArgs e)
        {

            Rectangle senderRect = sender as Rectangle;
            if (senderRect != null)
            {
                ResizeInProcess = true;
                senderRect.CaptureMouse();
            }
        }
        #endregion

        private void Resize_End(object sender, MouseButtonEventArgs e)
        {
            Rectangle senderRect = sender as Rectangle;
            if (senderRect != null)
            {
                ResizeInProcess = false; ;
                senderRect.ReleaseMouseCapture();
            }
        }

        private void Resizeing_Form(object sender, MouseEventArgs e)
        {
            if (ResizeInProcess)
            {
                Rectangle senderRect = sender as Rectangle;
                Window mainWindow = senderRect.Tag as Window;
                if (senderRect != null)
                {
                    double width = e.GetPosition(mainWindow).X;
                    double height = e.GetPosition(mainWindow).Y;
                    senderRect.CaptureMouse();
                    if (senderRect.Name.ToLower().Contains("right"))
                    {
                        width += 5;
                        if (width > 0)
                            mainWindow.Width = width;
                    }
                    if (senderRect.Name.ToLower().Contains("left"))
                    {
                        width -= 5;
                        mainWindow.Left += width;
                        width = mainWindow.Width - width;
                        if (width > 0)
                        {
                            mainWindow.Width = width;
                        }
                    }
                    if (senderRect.Name.ToLower().Contains("bottom"))
                    {
                        height += 5;
                        if (height > 0)
                            mainWindow.Height = height;
                    }
                    if (senderRect.Name.ToLower().Contains("top"))
                    {
                        height -= 5;
                        mainWindow.Top += height;
                        height = mainWindow.Height - height;
                        if (height > 0)
                        {
                            mainWindow.Height = height;
                        }
                    }
                }
            }
        }

        #region TitleButtons

        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            //App.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        #endregion

        private void MaximizeClick(object sender, RoutedEventArgs e)
        {
            AdjustWindowSize();
        }

        private void AdjustWindowSize()
        {
            //if (App.Current.MainWindow.WindowState == WindowState.Maximized)
            //{
            //    App.Current.MainWindow.WindowState = WindowState.Normal;
            //    MaximizeButton.Content = "";
            //}
            //else if (App.Current.MainWindow.WindowState == WindowState.Normal)
            //{
            //    App.Current.MainWindow.WindowState = WindowState.Maximized;
            //    MaximizeButton.Content = "";
            //}
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {

            //System.Windows.Application.Current.Shutdown();
            this.Close();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (e.ClickCount == 2)
                {
                    AdjustWindowSize();
                }
                else
                {
                    //App.Current.MainWindow.DragMove();
                }
            }
        }
    }
}
