using Keysight.Ccl.Wsl.UI;
using Keysight.Ccl.Wsl.UI.Managers;
using MainApplication;
using MainApplication.CommonUtils;
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

namespace MainApplication.SecuritySample
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      UXManager.Initialize();
      Settings.SetActiproColorSchemeAccordingToWSL();
      DataContext = this;
      InitializeComponent();
    }

    private void x_caranuDark_Click(object sender, RoutedEventArgs e)
    {
      SkinManager.Instance.ColorSkinFragment = "Caranu Dark";
      ApplyTheme();
    }

    private void ApplyTheme()
    {
      if ((SkinManager.Instance.ColorSkinFragment == "Caranu Dark") && (ApplicationContext.ThemeType == "Caranu Dark"))
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

    private void x_caranuLight_Click(object sender, RoutedEventArgs e)
    {
      SkinManager.Instance.ColorSkinFragment = "Caranu Light";
      ApplyTheme();

    }

    private void ApplicationSecurity_Click(object sender, RoutedEventArgs e)
    {
      //AppSecuritySample appsec = new AppSecuritySample();
      //appsec.Show();

      AppSecuritySample appsec = new AppSecuritySample();
      appsec.ShowInTaskbar = false;
      appsec.Owner = Application.Current.MainWindow;
      appsec.Show();
    }

    private void Encrypt_Decrypt_Click(object sender, RoutedEventArgs e)
    {
      Encrypt_Decrypt ed = new Encrypt_Decrypt();
      ed.ShowInTaskbar = false;
      ed.Owner = Application.Current.MainWindow;
      ed.Show();
    }
  }
}
