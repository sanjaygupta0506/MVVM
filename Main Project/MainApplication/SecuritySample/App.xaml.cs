using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MainApplication.SecuritySample
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Create the ViewModel and expose it using the View's DataContext
            MainWindow view = new MainWindow();
            view.DataContext = new ViewModels.HashingViewModel();
            view.Show();
        }
    }
}
