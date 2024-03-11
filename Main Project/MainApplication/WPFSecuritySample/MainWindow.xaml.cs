using Keysight.Ccl.Wsl.UI;
using Keysight.Ccl.Wsl.UI.Managers;
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

namespace MainApplication
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void x_caranuDark_Click(object sender, RoutedEventArgs e)
    {
      UXManager.Initialize();
      ApplicationContext.ThemeType = "Caranu Light";
      ApplyTheme();
    }

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

    private void x_caranuLight_Click(object sender, RoutedEventArgs e)
    {
      ApplicationContext.ThemeType = "Caranu Dark";
      ApplyTheme();

    }
  }
}
