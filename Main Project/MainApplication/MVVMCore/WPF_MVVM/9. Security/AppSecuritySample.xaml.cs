using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Keysight.Ccl.Wsl.UI;
using Keysight.Ccl.Wsl.UI.Managers;
using MainApplication.CommonUtils;
using MVVMCore;


namespace MainApplication.SecuritySample
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class AppSecuritySample : WslDialog
  {
    private Brush m_textBrush;
    private Brush m_textErrorBrush;
    private Brush m_backBrush;
    private Brush m_columnHeaderBackBrush;
    private Brush m_backErrorBrush;
    private Brush m_backBrushAlt;
    public AppSecuritySample()
    {
      InitializeComponent();
      _viewModel = (EmployeeViewModel)
      this.Resources["viewModel"];
      SkinManager.Instance.SkinChanged += KsWsl_ThemeChanged;
    }

    private void KsWsl_ThemeChanged(object sender, SkinChangedEventArgs e)
    {
      ApplyTheme();
    }

    public void ApplyTheme()
    {
     
      Background = ThemeMgr.ThemeBackgroundColour;
      Foreground = ThemeMgr.ThemeForgroundColour;
    }

    private readonly EmployeeViewModel _viewModel;

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      // Set your Security Principal  
      SetSecurityPrincipal();

      // Secure controls on this WPF window  
      _viewModel.SecureControls(this, "EmployeeControl");
    }

    private void SetSecurityPrincipal()
    {
      // Set Principal to a WindowsPrincipal  
      Thread.GetDomain().SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);

      // NOTE: You can create a GenericPrincipal here with your own credentials and roles
    }
  }

}
