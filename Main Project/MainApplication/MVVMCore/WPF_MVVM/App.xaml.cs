using MVVMCore.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMCore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en"); 
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MVVMCore.MainApp mainApp = new MVVMCore.MainApp();
            mainApp.Show();



            //MVVMPattern.UserInfo userInfo = new MVVMPattern.UserInfo();
            //UserInfoViewModel UIVM = new UserInfoViewModel();
            //userInfo.DataContext = UIVM;
            //userInfo.Show();

            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");
           // System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
        }
    }
}
