using MVVMCore;
using MVVMCore.Challanges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFAssignment.Security;


namespace WPFAssignment
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

    private void x_GridHeader_Click(object sender, RoutedEventArgs e)
    {
      //CustomDataGrid datagridHeaderColorchanged = new CustomDataGrid();
      //datagridHeaderColorchanged.Show();
    }
    private void x_WPFTitleBar_Click(object sender, RoutedEventArgs e)
    {
      //WPFTitleBarExample wPFTitleBarExample = new WPFTitleBarExample();
      //wPFTitleBarExample.Show();
    }


    private void x_WPFScrollBar_Click(object sender, RoutedEventArgs e)
    {
      WPFScrollBar wPFScrollBar = new WPFScrollBar();
      wPFScrollBar.Show();
    }

    private void x_WPFDatagridComboBox_Click(object sender, RoutedEventArgs e)
    {
      WPFDatagridCombobox wPFDatagridCombobox = new WPFDatagridCombobox();
      wPFDatagridCombobox.Show();
    }

    private void x_InfragisticUltragrid_Click(object sender, RoutedEventArgs e)
    {
      UltraGridDemo ultraGridDemo = new UltraGridDemo();
      ultraGridDemo.Show();
    }

    private void x_InfragisticDockManager_Click(object sender, RoutedEventArgs e)
    {
      InfragisticDockManager infragisticDockManager = new InfragisticDockManager();
      infragisticDockManager.Show();
    }

    private void x_InfragisticDockManagerN_Click(object sender, RoutedEventArgs e)
    {
      InfragisticDockManagerN infragisticDockManagerN = new InfragisticDockManagerN();
      infragisticDockManagerN.Show();
    }

    private void x_combowithEnum_Click(object sender, RoutedEventArgs e)
    {
      // CombowithEnum combowithEnum = new CombowithEnum();
      //this.childre
    }

    private void x_DynamicResource_Click(object sender, RoutedEventArgs e)
    {
      CustomStyleOnControls customStyleOnControls = new CustomStyleOnControls();
      customStyleOnControls.Show();
    }

    private void x_CommonControl_Click(object sender, RoutedEventArgs e)
    {
      CommonControls commonControls = new CommonControls();
      commonControls.Show();
    }

    private void x_SearchTextBox_Click(object sender, RoutedEventArgs e)
    {
      SearchTextBoxUI searchTextBoxUI = new SearchTextBoxUI();
      searchTextBoxUI.Show();
    }

    private void x_DataGridSingleClickCheckbox_Click(object sender, RoutedEventArgs e)
    {
      MainWindow mainWindow = new MainWindow();
      mainWindow.Show();
    }

    private void x_Trigger_Click(object sender, RoutedEventArgs e)
    {
      SerialTriggerWindow serialTriggerWindow = new SerialTriggerWindow();
      serialTriggerWindow.Show();
    }

    private void Encryption_Desryption_Click(object sender, RoutedEventArgs e)
    {
      Encryption_Descryption ED = new Encryption_Descryption();
      ED.Show();
    }

    private void x_caranuDark_Click(object sender, RoutedEventArgs e)
    {

      //ApplicationContext.ThemeType = "Caranu Dark";
      ApplyTheme();
    }

    private void ApplyTheme()
    {
#pragma warning disable CS0436 // Type conflicts with imported type
      //ThemeMgr.SetCaranuColorTheme(ApplicationContext.ThemeType);
#pragma warning restore CS0436 // Type conflicts with imported type
    }

    private void x_caranuLight_Click(object sender, RoutedEventArgs e)
    {
      ApplyTheme();
    }

    private void x_file_Click(object sender, RoutedEventArgs e)
    {

    }

    private void x_form_Click(object sender, RoutedEventArgs e)
    {

    }
  }
}
