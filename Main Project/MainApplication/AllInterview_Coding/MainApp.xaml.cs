
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


using Keysight.Ccl.Wsl.UI;

using MainApplication;
using Keysight.Ccl.Wsl.UI.Managers;

using System.Windows.Threading;

using System.Data.Common;

using MVVMCore.Challanges;
using MainApplication.WPF_Assignment.Common;
using MainApplication.WPF_Assignment.CompanyWise;
using MVVMCore.WPF_MVVM;
using MainApplication.WPF_MVVM;
using MVVMCore.WPF_MVVM.Challanges;
using WPF_MVVM.View;

using MainApplication.WPF_MVVM._8._Interview.ValueConvertor;

using MainApplication.WPF_MVVM._8._Interview.MostlyAsked_Coding;
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

        

       

        private void x_Challanges1_Click(object sender, RoutedEventArgs e)
        {
            SingleClickCheckboxOnGrid singleClickCheckboxOnGrid = new SingleClickCheckboxOnGrid();
            singleClickCheckboxOnGrid.ShowInTaskbar = false;
            singleClickCheckboxOnGrid.Owner = Application.Current.MainWindow;
            singleClickCheckboxOnGrid.Show();
        }

        private void x_Challanges2_Click(object sender, RoutedEventArgs e)
        {
            Enabled_Disabled_Button_WRT_Property enabled_Disabled_Button_WRT_Property = new Enabled_Disabled_Button_WRT_Property();
            enabled_Disabled_Button_WRT_Property.ShowInTaskbar = false;
            enabled_Disabled_Button_WRT_Property.Owner = Application.Current.MainWindow;
            enabled_Disabled_Button_WRT_Property.Show();
            
        }

        private void x_Challanges3_Click(object sender, RoutedEventArgs e)
        {
            ScrollBar scrollBar = new ScrollBar();
            scrollBar.ShowInTaskbar = false;
            scrollBar.Owner = Application.Current.MainWindow;
            scrollBar.Show();
        }

        private void x_Challanges4_Click(object sender, RoutedEventArgs e)
        {
            TitleBar titleBar = new TitleBar();
            titleBar.ShowInTaskbar = false;
            titleBar.Owner = Application.Current.MainWindow;
            titleBar.Show();
        }

        private void x_Challanges5_Click(object sender, RoutedEventArgs e)
        {
            BtnEnableOnTextChange btnEnableOnTextChange = new BtnEnableOnTextChange();
            btnEnableOnTextChange.ShowInTaskbar = false;
            btnEnableOnTextChange.Owner = Application.Current.MainWindow;
            btnEnableOnTextChange.Show();
        }

        private void x_Challanges6_Click(object sender, RoutedEventArgs e)
        {
            ComboColorChangeFromRadio comboColorChangeFromRadio = new ComboColorChangeFromRadio();
            comboColorChangeFromRadio.ShowInTaskbar = false;
            comboColorChangeFromRadio.Owner = Application.Current.MainWindow;
            comboColorChangeFromRadio.Show();
        }

        private void x_Challanges7_Click(object sender, RoutedEventArgs e)
        {
            FirstNameLastNameinCombo firstNameLastNameinCombo = new FirstNameLastNameinCombo();
            firstNameLastNameinCombo.ShowInTaskbar = false;
            firstNameLastNameinCombo.Owner = Application.Current.MainWindow;
            firstNameLastNameinCombo.Show();
        }

        private void x_Challanges8_Click(object sender, RoutedEventArgs e)
        {
            ListToRadioButton listToRadioButton = new ListToRadioButton();
            listToRadioButton.ShowInTaskbar = false;
            listToRadioButton.Owner = Application.Current.MainWindow;
            listToRadioButton.Show();
        }

        private void x_Challanges9_Click(object sender, RoutedEventArgs e)
        {
            TreeViewColorChangeOnRadio treeViewColorChangeOnRadio = new TreeViewColorChangeOnRadio();
            treeViewColorChangeOnRadio.ShowInTaskbar = false;
            treeViewColorChangeOnRadio.Owner = Application.Current.MainWindow;
            treeViewColorChangeOnRadio.Show();
        }

        private void x_Challanges10_Click(object sender, RoutedEventArgs e)
        {
            Stryker stryker = new Stryker();
            stryker.ShowInTaskbar = false;
            stryker.Owner = Application.Current.MainWindow;
            stryker.Show();
        }

        private void x_Challanges11_Click(object sender, RoutedEventArgs e)
        {
            Encryption_Descryption encryption_Descryption = new Encryption_Descryption();
            encryption_Descryption.ShowInTaskbar = false;
            encryption_Descryption.Owner = Application.Current.MainWindow;
            encryption_Descryption.Show();
        }

        private void x_CustomControl_Click(object sender, RoutedEventArgs e)
        {
            CustomControl customControl = new CustomControl();
            customControl.ShowInTaskbar = false;
            customControl.Owner = Application.Current.MainWindow;
            customControl.Show();
        }

        private void x_TwoWayBinding_Click(object sender, RoutedEventArgs e)
        {
            TwoWayBinding twoWayBinding = new TwoWayBinding();
            twoWayBinding.ShowInTaskbar = false;
            twoWayBinding.Owner = Application.Current.MainWindow;
            twoWayBinding.Show();
        }

       

        private void x_UpperCaseConvertor_Click(object sender, RoutedEventArgs e)
        {
            UpperCaseConverterUI uccui = new UpperCaseConverterUI();
            uccui.ShowInTaskbar = false;
            uccui.Owner = Application.Current.MainWindow;
            uccui.Show();
        }

        

        private void x_DataTrigger_Click(object sender, RoutedEventArgs e)
        {
            DataTriggerExample dataTriggerExample = new DataTriggerExample();
            dataTriggerExample.ShowInTaskbar = false;
            dataTriggerExample.Owner = Application.Current.MainWindow;
            dataTriggerExample.Show();
        }

        private void x_DependencyPropertyExample_Click(object sender, RoutedEventArgs e)
        {
            DependencyPropertyExample dependencyPropertyExample = new DependencyPropertyExample();
            dependencyPropertyExample.ShowInTaskbar = false;
            dependencyPropertyExample.Owner = Application.Current.MainWindow;
            dependencyPropertyExample.Show();
        }

        private void x_DataBindingExample_Click(object sender, RoutedEventArgs e)
        {
            DataBindingExample dataBindingExample = new DataBindingExample();
            dataBindingExample.ShowInTaskbar = false;
            dataBindingExample.Owner = Application.Current.MainWindow;
            dataBindingExample.Show();
        }

        private void x_ObservableCollectionExample_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollectionExample observableCollectionExample = new ObservableCollectionExample();
            observableCollectionExample.ShowInTaskbar = false;
            observableCollectionExample.Owner = Application.Current.MainWindow;
            observableCollectionExample.Show();
        }

        private void x_ICommandExample_Click(object sender, RoutedEventArgs e)
        {
            ICommandExample iCommandExample = new ICommandExample();
            iCommandExample.ShowInTaskbar = false;
            iCommandExample.Owner = Application.Current.MainWindow;
            iCommandExample.Show();
        }

        private void x_ProprtyTriggerExample_Click(object sender, RoutedEventArgs e)
        {
            PropertyTriggerExample propertyTriggerExample = new PropertyTriggerExample();
            propertyTriggerExample.ShowInTaskbar = false;
            propertyTriggerExample.Owner = Application.Current.MainWindow;
            propertyTriggerExample.Show();
        }
    }
}
