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
using ActiproSoftware.Windows.Controls.Docking;
using Keysight.Ccl.Wsl.UI;
using MainApplication;
using Keysight.Ccl.Wsl.UI.Managers;
using MainApplication.WPF_MVVM.SOLID_Princliple.SRP;
using System.Windows.Threading;
using MainApplication.WPF_MVVM.MultiThreading;
using MainApplication.WPF_MVVM.Design_Pattern.Singletons;
using System.Data.Common;
using MainApplication.WPF_MVVM._4._Design_Pattern.Deppendency_Injection.Method;
using MainApplication.WPF_MVVM._4._Design_Pattern.Deppendency_Injection.Property;
using MainApplication.WPF_MVVM._4._Design_Pattern.Deppendency_Injection.Constructor;
using MainApplication.WPF_MVVM._4._Design_Pattern.Factory_Method;
using MainApplication.WPF_MVVM._4._Design_Pattern.Abstract;
using MainApplication.CommonUtils;


namespace MVVMCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainApp : WslMainWindow
    {
       
        public MainApp()
        {
            InitializeComponent();
            UXManager.Initialize();
            ApplicationContext.ThemeType = "Caranu Light";
            ApplyTheme();
        }

        #region Common
        private void ApplyTheme()
        {
            if (SkinManager.Instance.ColorSkinFragment == "Caranu Dark")
            {
                this.Background = ThemeMgr.ThemeBackgroundColour;
                this.Foreground = ThemeMgr.ThemeForgroundColour;
            }
            else
            {
                this.Background = ThemeMgr.ThemeBackgroundColour;
                this.Foreground = ThemeMgr.ThemeForgroundColour;
            }
        }
        #endregion

       

        #region Multi-Threading
        private void x_Dispather_Click(object sender, RoutedEventArgs e)
        {
            DispatcherExample dispatcherExample = new DispatcherExample();
            dispatcherExample.ShowInTaskbar = false;
            dispatcherExample.Owner = Application.Current.MainWindow;
            dispatcherExample.Show();
        }
        private void x_bgThread_Click(object sender, RoutedEventArgs e)
        {
            BackGroundWorkerExample backGroundWorkerExample = new BackGroundWorkerExample();
            backGroundWorkerExample.ShowInTaskbar = false;
            backGroundWorkerExample.Owner = Application.Current.MainWindow;
            backGroundWorkerExample.Show();
        }
        private void x_st_Click(object sender, RoutedEventArgs e)
        {
            SingleThread singleThread = new SingleThread();
            singleThread.ShowInTaskbar = false;
            singleThread.Owner = Application.Current.MainWindow;
            singleThread.Show();
        }
        #endregion

        

        #region SOLID Principles
        private void x_SR_Click(object sender, RoutedEventArgs e)
        {
            SRP srp = new SRP();
            srp.ShowInTaskbar = false;
            srp.Owner = Application.Current.MainWindow;
            srp.Show();
        }
        #endregion

        #region Design Pattern
        private void x_SingleTonDP_Click(object sender, RoutedEventArgs e)
        {
            SingletonDemo singletonDemo = new SingletonDemo();
            singletonDemo.ShowInTaskbar = false;
            singletonDemo.Owner = Application.Current.MainWindow;
            singletonDemo.Show();
        }
        #endregion

        #region View
        private void x_caranuDark_Click(object sender, RoutedEventArgs e)
        {
            SkinManager.Instance.ColorSkinFragment = "Caranu Dark";
            ApplyTheme();
        }
        private void x_caranuLight_Click(object sender, RoutedEventArgs e)
        {
            SkinManager.Instance.ColorSkinFragment = "Caranu Light";
            ApplyTheme();
        }





        #endregion

        

        private void x_SingleTonDType_Click(object sender, RoutedEventArgs e)
        {
            Singleton_Types singleton_Types = new Singleton_Types();
            singleton_Types.ShowInTaskbar = false;
            singleton_Types.Owner = Application.Current.MainWindow;
            singleton_Types.Show();
        }

        private void x_DIConstructor_Click(object sender, RoutedEventArgs e)
        {
            DIContructor dIContructor = new DIContructor();
            dIContructor.ShowInTaskbar = false;
            dIContructor.Owner = Application.Current.MainWindow;
            dIContructor.Show();
        }

        private void x_DIMethod_Click(object sender, RoutedEventArgs e)
        {
            DIMethod dIMethod = new DIMethod();
            dIMethod.ShowInTaskbar = false;
            dIMethod.Owner = Application.Current.MainWindow;
            dIMethod.Show();
        }

        private void x_DIPropety_Click(object sender, RoutedEventArgs e)
        {
            DIProperty dIProperty = new DIProperty();
            dIProperty.ShowInTaskbar = false;
            dIProperty.Owner = Application.Current.MainWindow;
            dIProperty.Show();
        }

        

        private void x_FactoryMethod_Click(object sender, RoutedEventArgs e)
        {
            FactoryMethod factoryMethod = new FactoryMethod();
            factoryMethod.ShowInTaskbar = false;
            factoryMethod.Owner = Application.Current.MainWindow;
            factoryMethod.Show();
        }

        private void x_AbstractFactory_Click(object sender, RoutedEventArgs e)
        {
            AbstractFactory abstractFactory = new AbstractFactory();
            abstractFactory.ShowInTaskbar = false;
            abstractFactory.Owner = Application.Current.MainWindow;
            abstractFactory.Show();
        }

        private void x_WPFDispather_Click(object sender, RoutedEventArgs e)
        {
            //WPFDispatcherExample WPFDispatcherExample = new WPFDispatcherExample();
            //abstractFactory.ShowInTaskbar = false;
            //abstractFactory.Owner = Application.Current.MainWindow;
            //abstractFactory.Show();
        }

        

       

        
    }
}
