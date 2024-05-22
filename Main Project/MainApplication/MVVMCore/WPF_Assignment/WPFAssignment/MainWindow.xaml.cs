using Keysight.Ccl.Wsl.UI;
using MVVMCore.Challanges;
using System.Windows;
using WPFAssignment.Security;
using MainApplication.WPF_Assignment.CompanyWise;
using MainApplication.CommonUtils;
using Keysight.Ccl.Wsl.UI.Managers;
using MainApplication.WPF_Assignment.Common;

namespace WPFAssignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : WslMainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            UXManager.Initialize();
            ApplicationContext.ThemeType = "Caranu Light";
            ApplyTheme();
        }

        #region Common
        private void x_caranuDark_Click(object sender, RoutedEventArgs e)
        {
            SkinManager.Instance.ColorSkinFragment = "Caranu Dark";
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
            SkinManager.Instance.ColorSkinFragment = "Caranu Light";
            ApplyTheme();
        }
        #endregion

        private void x_WPFTitleBar_Click(object sender, RoutedEventArgs e)
        {
            WPFTitleBarExample wPFTitleBarExample = new WPFTitleBarExample();
            wPFTitleBarExample.ShowInTaskbar = false;
            wPFTitleBarExample.Owner = Application.Current.MainWindow;
            wPFTitleBarExample.Show();
        }


        private void x_WPFScrollBar_Click(object sender, RoutedEventArgs e)
        {
            WPFScrollBar wPFScrollBar = new WPFScrollBar();
            wPFScrollBar.ShowInTaskbar = false;
            wPFScrollBar.Owner = Application.Current.MainWindow;
            wPFScrollBar.Show();
        }

        private void Encryption_Desryption_Click(object sender, RoutedEventArgs e)
        {
            Encryption_Descryption ED = new Encryption_Descryption();
            ED.ShowInTaskbar = false;
            ED.Owner = Application.Current.MainWindow;
            ED.Show();
        }
        private void x_file_Click(object sender, RoutedEventArgs e)
        {

        }

        private void x_form_Click(object sender, RoutedEventArgs e)
        {

        }

        private void x_Stryker_Click(object sender, RoutedEventArgs e)
        {
            Stryker stryker = new Stryker();
            stryker.ShowInTaskbar = false;
            stryker.Owner = Application.Current.MainWindow;
            stryker.Show();
        }

        #region Comman Task
        private void x_BtnEnableOnTextChange_Click(object sender, RoutedEventArgs e)
        {
            BtnEnableOnTextChange btnEnableOnTextChange = new BtnEnableOnTextChange();
            btnEnableOnTextChange.ShowInTaskbar = false;
            btnEnableOnTextChange.Owner = Application.Current.MainWindow;
            btnEnableOnTextChange.Show();
        }

        private void x_ComboColorChangeFromRadio_Click(object sender, RoutedEventArgs e)
        {
            ComboColorChangeFromRadio comboColorChangeFromRadio = new ComboColorChangeFromRadio();
            comboColorChangeFromRadio.ShowInTaskbar = false;
            comboColorChangeFromRadio.Owner = Application.Current.MainWindow;
            comboColorChangeFromRadio.Show();
        }
        #endregion

        private void x_FirstNameLastNameinCombo_Click(object sender, RoutedEventArgs e)
        {
            FirstNameLastNameinCombo firstNameLastNameinCombo = new FirstNameLastNameinCombo();
            firstNameLastNameinCombo.ShowInTaskbar = false;
            firstNameLastNameinCombo.Owner = Application.Current.MainWindow;
            firstNameLastNameinCombo.Show();
        }

        private void x_ListToRadioButton_Click(object sender, RoutedEventArgs e)
        {
            ListToRadioButton listToRadioButton = new ListToRadioButton();
            listToRadioButton.ShowInTaskbar = false;
            listToRadioButton.Owner = Application.Current.MainWindow;
            listToRadioButton.Show();
        }

        private void x_TreeViewColorChangeOnRadio_Click(object sender, RoutedEventArgs e)
        {
            TreeViewColorChangeOnRadio treeViewColorChangeOnRadio = new TreeViewColorChangeOnRadio();
            treeViewColorChangeOnRadio.ShowInTaskbar = false;
            treeViewColorChangeOnRadio.Owner = Application.Current.MainWindow;
            treeViewColorChangeOnRadio.Show();
        }
    }
}
