using MVVMCore.MVVMPattern;
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
using MVVMCore.Resources;
using MVVMCore.DataBindings;
using MVVMCore.INotifyPropertyChangedSample;
using MVVMCore.ViewModel;
using ActiproSoftware.Windows.Controls.Docking;
using Keysight.Ccl.Wsl.UI;
using MVVMCore.DataContext;
using MVVMCore.ValueConvertors;
using MVVMCore.DependencyPropertySample;
using MVVMCore.Commands;
using MVVMCore.Styles;
using MVVMCore.Triggers;
using MVVMCore.Templates.DataTemplates;
using MVVMCore.DataGridSingleClickCheckbox.Views;
using MainApplication;
using Keysight.Ccl.Wsl.UI.Managers;
using MainApplication.CommonUtils;
using MainApplication.WPF_MVVM.WPFMVVMBasic.Resources;
using MainApplication.WPF_MVVM.SOLID_Princliple.SRP;
using System.Windows.Threading;
using MainApplication.WPF_MVVM.MultiThreading;
using MainApplication.WPF_MVVM.WPFMVVMPattern;
using MainApplication.WPF_MVVM.Design_Pattern.Singletons;
using MainApplication.WPF_MVVM.WPFMVVMBasic.Triggers;
using System.Data.Common;
using MainApplication.WPF_MVVM.WPFMVVMAdvance.AttachedPropertySample;
using MainApplication.WPF_MVVM.WPFMVVMBasic.Layouts;
using MainApplication.WPF_MVVM.WPFMVVMBasic.Styles;
using MainApplication.WPF_MVVM.WPFMVVMBasic.DataBindings;
using MainApplication.WPF_MVVM.WPFMVVMBasic.Templates;
using MainApplication.WPF_MVVM.WPFMVVMAdvance.Localization;
using MainApplication.WPF_MVVM.WPFMVVMAdvance.DependencyPropertySample;
using MainApplication.WPF_MVVM.WPFMVVMBasic.RoutedEvents;
using MainApplication.WPF_MVVM.WPFMVVMAdvance.Virtualization;
using MainApplication.WPF_MVVM.WPFMVVMAdvance;
using MainApplication.WPF_MVVM.WPFMVVMBasic.Commands.Views;
using MainApplication.WPF_MVVM.WPFMVVMBasic.Commands.ViewModel;
using MainApplication.WPF_MVVM._1._WPFMVVMBasic._1._MVVM_Main.Pattern3;
using MainApplication.WPF_MVVM._4._Design_Pattern.Deppendency_Injection.Method;
using MainApplication.WPF_MVVM._4._Design_Pattern.Deppendency_Injection.Property;
using MainApplication.WPF_MVVM._4._Design_Pattern.Deppendency_Injection.Constructor;
using MainApplication.WPF_MVVM._2._WPFMVVMAdvance._2._AttachedPropertySample.Pattern1;
using MainApplication.WPF_MVVM._1._WPFMVVMBasic.RelativeSource;
using MainApplication.WPF_MVVM._1._WPFMVVMBasic.UpdateSourceTrigger;

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

        #region MVVM Basic

        #region DataBindings

        private void Binding_Main_Click(object sender, RoutedEventArgs e)
        {
            Binding_Main binding_Main = new Binding_Main();
            binding_Main.ShowInTaskbar = false;
            binding_Main.Owner = Application.Current.MainWindow;
            binding_Main.Show();
        }
        private void Binding_Default_Click(object sender, RoutedEventArgs e)
        {
            Binding_Default binding_Default = new Binding_Default();
            binding_Default.ShowInTaskbar = false;
            binding_Default.Owner = Application.Current.MainWindow;
            binding_Default.Show();
        }
        private void Binding_OneWay_Click(object sender, RoutedEventArgs e)
        {
            Binding_OneWay binding_OneWay = new Binding_OneWay();
            binding_OneWay.ShowInTaskbar = false;
            binding_OneWay.Owner = Application.Current.MainWindow;
            binding_OneWay.Show();
        }
        private void Binding_TwoWay_Click(object sender, RoutedEventArgs e)
        {
            Binding_TwoWay binding_TwoWay = new Binding_TwoWay();
            binding_TwoWay.ShowInTaskbar = false;
            binding_TwoWay.Owner = Application.Current.MainWindow;
            binding_TwoWay.Show();
        }
        private void Binding_OneWaytoSource_Click(object sender, RoutedEventArgs e)
        {
            Binding_OneWayToSource binding_OneWayToSource = new Binding_OneWayToSource();
            binding_OneWayToSource.ShowInTaskbar = false;
            binding_OneWayToSource.Owner = Application.Current.MainWindow;
            binding_OneWayToSource.Show();
        }
        private void Binding_OneTime_Click(object sender, RoutedEventArgs e)
        {
            Binding_OneTime binding_OneTime = new Binding_OneTime();
            binding_OneTime.ShowInTaskbar = false;
            binding_OneTime.Owner = Application.Current.MainWindow;
            binding_OneTime.Show();
        }


        #endregion

        #region Resources

        private void StaticResources_Click(object sender, RoutedEventArgs e)
        {
            StaticResourceExample resources = new StaticResourceExample();
            resources.ShowInTaskbar = false;
            resources.Owner = Application.Current.MainWindow;
            resources.Show();
        }
        private void DynamicResources_Click(object sender, RoutedEventArgs e)
        {
            DynamicResourceExample resource = new DynamicResourceExample();
            resource.ShowInTaskbar = false;
            resource.Owner = Application.Current.MainWindow;
            resource.Show();
        }
        private void RelativeSource_Self_Click(object sender, RoutedEventArgs e)
        {
            RelativeSource_Self relativeSource_Self = new RelativeSource_Self();
            relativeSource_Self.ShowInTaskbar = false;
            relativeSource_Self.Owner = Application.Current.MainWindow;
            relativeSource_Self.Show();
        }
        private void RelativeSource_FindAncestor_Click(object sender, RoutedEventArgs e)
        {
            RelativeSource_FindAncestor relativeSource_FindAncestor = new RelativeSource_FindAncestor();
            relativeSource_FindAncestor.ShowInTaskbar = false;
            relativeSource_FindAncestor.Owner = Application.Current.MainWindow;
            relativeSource_FindAncestor.Show();
        }
        private void RelativeSource_TemplatedParent_Click(object sender, RoutedEventArgs e)
        {
            RelativeSource_TemplatedParent relativeSource_TemplatedParent = new RelativeSource_TemplatedParent();
            relativeSource_TemplatedParent.ShowInTaskbar = false;
            relativeSource_TemplatedParent.Owner = Application.Current.MainWindow;
            relativeSource_TemplatedParent.Show();
        }


        #endregion

        private void HierarchialDataTemplate_Click(object sender, RoutedEventArgs e)
        {
            Template_HierarchialData template_HierarchialData = new Template_HierarchialData();
            template_HierarchialData.ShowInTaskbar = false;
            template_HierarchialData.Owner = Application.Current.MainWindow;
            template_HierarchialData.Show();
        }

     

        private void SampleMVVM_Click(object sender, RoutedEventArgs e)
        {
            SamplesMVVM sampleMVVM = new SamplesMVVM();
            sampleMVVM.ShowInTaskbar = false;
            sampleMVVM.Owner = Application.Current.MainWindow;
            sampleMVVM.Show();
        }

        private void UserInfoMVVM_Click(object sender, RoutedEventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.ShowInTaskbar = false;
            userInfo.Owner = Application.Current.MainWindow;
            userInfo.Show();
        }

        private void StudentInfoMVVM_Click(object sender, RoutedEventArgs e)
        {
            StudentInfo studentInfo = new StudentInfo();
            studentInfo.ShowInTaskbar = false;
            studentInfo.Owner = Application.Current.MainWindow;
            studentInfo.Show();
        }


        private void INotifyPropertyChanged_Click(object sender, RoutedEventArgs e)
        {
            INotifyPropertyChangedExample iNotifyPropertyChangedExample = new INotifyPropertyChangedExample();
            iNotifyPropertyChangedExample.ShowInTaskbar = false;
            iNotifyPropertyChangedExample.Owner = Application.Current.MainWindow;
            iNotifyPropertyChangedExample.Show();
        }
        private void DataContext_Click(object sender, RoutedEventArgs e)
        {
            DataContextExample dataContextExample = new DataContextExample();
            dataContextExample.ShowInTaskbar = false;
            dataContextExample.Owner = Application.Current.MainWindow;
            dataContextExample.Show();
        }
        private void ValueConvertors_Click(object sender, RoutedEventArgs e)
        {
            ValueConvertorsExample valueConvertorsExample = new ValueConvertorsExample();
            valueConvertorsExample.ShowInTaskbar = false;
            valueConvertorsExample.Owner = Application.Current.MainWindow;
            valueConvertorsExample.Show();
        }
        private void Commands_Click(object sender, RoutedEventArgs e)
        {
            CommandsExample commandsExample = new CommandsExample();
            commandsExample.ShowInTaskbar = false;
            commandsExample.Owner = Application.Current.MainWindow;
            commandsExample.Show();
        }
        private void MainStyle_Click(object sender, RoutedEventArgs e)
        {
            StylesExample stylesExample = new StylesExample();
            stylesExample.ShowInTaskbar = false;
            stylesExample.Owner = Application.Current.MainWindow;
            stylesExample.Show();
        }
        private void StyleInheritance_Click(object sender, RoutedEventArgs e)
        {
            StyleInheritanceExample styleInheritanceExample = new StyleInheritanceExample();
            styleInheritanceExample.ShowInTaskbar = false;
            styleInheritanceExample.Owner = Application.Current.MainWindow;
            styleInheritanceExample.Show();
        }
        private void MainTriggers_Click(object sender, RoutedEventArgs e)
        {
            MainTriggersExample triggersExample = new MainTriggersExample();
            triggersExample.ShowInTaskbar = false;
            triggersExample.Owner = Application.Current.MainWindow;
            triggersExample.Show();
        }
        private void PropertyTrigger_Click(object sender, RoutedEventArgs e)
        {
            Trigger_Property propertyTrigger = new Trigger_Property();
            propertyTrigger.ShowInTaskbar = false;
            propertyTrigger.Owner = Application.Current.MainWindow;
            propertyTrigger.Show();
        }
        private void EventTrigger_Click(object sender, RoutedEventArgs e)
        {
            Trigger_Event eventTrigger = new Trigger_Event();
            eventTrigger.ShowInTaskbar = false;
            eventTrigger.Owner = Application.Current.MainWindow;
            eventTrigger.Show();
        }
        private void DataTrigger_Click(object sender, RoutedEventArgs e)
        {
            Trigger_Data dataTriggerExample = new Trigger_Data();
            dataTriggerExample.ShowInTaskbar = false;
            dataTriggerExample.Owner = Application.Current.MainWindow;
            dataTriggerExample.Show();
        }
        private void DataTemplate_Click(object sender, RoutedEventArgs e)
        {
            Templete_Data dataTemplateExample = new Templete_Data();
            dataTemplateExample.ShowInTaskbar = false;
            dataTemplateExample.Owner = Application.Current.MainWindow;
            dataTemplateExample.Show();
        }
        private void ControlTemplate_Click(object sender, RoutedEventArgs e)
        {
            Template_Control template_Control = new Template_Control();
            template_Control.ShowInTaskbar = false;
            template_Control.Owner = Application.Current.MainWindow;
            template_Control.Show();
            template_Control.Show();
        }
        private void Layouts_Click(object sender, RoutedEventArgs e)
        {

        }
        private void RoutedEvents_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventsExample routedEventsExample = new RoutedEventsExample();
            routedEventsExample.ShowInTaskbar = false;
            routedEventsExample.Owner = Application.Current.MainWindow;
            routedEventsExample.Show();
        }

         

        

        private void ItemTemplate_Click(object sender, RoutedEventArgs e)
        {
            Template_ItemPanel template_ItemPanel = new Template_ItemPanel();
            template_ItemPanel.ShowInTaskbar = false;
            template_ItemPanel.Owner = Application.Current.MainWindow;
            template_ItemPanel.Show();
        }


        private void Command_Click(object sender, RoutedEventArgs e)
        {
            CommandsExample commandsExample = new CommandsExample();
            commandsExample.ShowInTaskbar = false;
            commandsExample.Owner = Application.Current.MainWindow;
            commandsExample.Show();
        }

        private void ICommand_Click(object sender, RoutedEventArgs e)
        {
            PersonView personView = new PersonView();
            PersonViewModel personViewModel = new PersonViewModel();
            personView.DataContext = personViewModel;
            personView.ShowInTaskbar = false;
            personView.Owner = Application.Current.MainWindow;
            personView.Show();
        }


        private void MultiTrigger_Click(object sender, RoutedEventArgs e)
        {
            Trigger_MultiTrigger multiTriggerExample = new Trigger_MultiTrigger();
            multiTriggerExample.ShowInTaskbar = false;
            multiTriggerExample.Owner = Application.Current.MainWindow;
            multiTriggerExample.Show();
        }

        private void MultiDataTrigger_Click(object sender, RoutedEventArgs e)
        {
            Trigger_MultiDataTrigger multiDataTriggerExample = new Trigger_MultiDataTrigger();
            multiDataTriggerExample.ShowInTaskbar = false;
            multiDataTriggerExample.Owner = Application.Current.MainWindow;
            multiDataTriggerExample.Show();
        }
        #endregion

        #region MVVM Advance

        private void DependencyProperty_Click(object sender, RoutedEventArgs e)
        {
            BasicDependencyProperty basicDependencyProperty = new BasicDependencyProperty();
            basicDependencyProperty.ShowInTaskbar = false;
            basicDependencyProperty.Owner = Application.Current.MainWindow;
            basicDependencyProperty.Show();
        }
        private void CustomDependencyProperty_Click(object sender, RoutedEventArgs e)
        {
            CustomDependencyProperty customDependencyProperty = new CustomDependencyProperty();
            customDependencyProperty.ShowInTaskbar = false;
            customDependencyProperty.Owner = Application.Current.MainWindow;
            customDependencyProperty.Show();
        }
        private void x_AttachedProperty_Click(object sender, RoutedEventArgs e)
        {
            AttachedPropertyExample attachedPropertyExample = new AttachedPropertyExample();
            attachedPropertyExample.ShowInTaskbar = false;
            attachedPropertyExample.Owner = Application.Current.MainWindow;
            attachedPropertyExample.Show();

            //APIDemo aPIDemo = new APIDemo();
            //aPIDemo.ShowInTaskbar = false;
            //aPIDemo.Owner = Application.Current.MainWindow;
            //aPIDemo.Show();
        }
        private void x_LogicalvsVisualTree_Click(object sender, RoutedEventArgs e)
        {
            LogicalVsVisualTree logicalVsVisualTree = new LogicalVsVisualTree();
            logicalVsVisualTree.ShowInTaskbar = false;
            logicalVsVisualTree.Owner = Application.Current.MainWindow;
            logicalVsVisualTree.Show();
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

        #region Application Security
        private void x_file_Click(object sender, RoutedEventArgs e)
        {

        }
        private void x_form_Click(object sender, RoutedEventArgs e)
        {

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

        private void x_Localization_Click(object sender, RoutedEventArgs e)
        {
            LocalizationSample localizationSample = new LocalizationSample();
            localizationSample.ShowInTaskbar = false;
            localizationSample.Owner = Application.Current.MainWindow;
            localizationSample.Show();
        }

        private void LayoutGrid_Click(object sender, RoutedEventArgs e)
        {
            Layout_Grid layout_Grid = new Layout_Grid();
            layout_Grid.ShowInTaskbar = false;
            layout_Grid.Owner = Application.Current.MainWindow;
            layout_Grid.Show();
        }

        private void LayoutDockPanel_Click(object sender, RoutedEventArgs e)
        {
            Layout_DockPanel layout_DockPanel = new Layout_DockPanel();
            layout_DockPanel.ShowInTaskbar = false;
            layout_DockPanel.Owner = Application.Current.MainWindow;
            layout_DockPanel.Show();
        }

        private void LayoutCanvas_Click(object sender, RoutedEventArgs e)
        {
            Layout_Canvas layout_Canvas = new Layout_Canvas();
            layout_Canvas.ShowInTaskbar = false;
            layout_Canvas.Owner = Application.Current.MainWindow;
            layout_Canvas.Show();

        }

        private void LayoutStackPanel_Click(object sender, RoutedEventArgs e)
        {
            Layout_StackPanel layout_StackPanel = new Layout_StackPanel();
            layout_StackPanel.ShowInTaskbar = false;
            layout_StackPanel.Owner = Application.Current.MainWindow;
            layout_StackPanel.Show();
        }

        private void LayoutWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            Layout_WrapPanel layout_WrapPanel = new Layout_WrapPanel();
            layout_WrapPanel.ShowInTaskbar = false;
            layout_WrapPanel.Owner = Application.Current.MainWindow;
            layout_WrapPanel.Show();
        }

        private void x_Virtualization_Click(object sender, RoutedEventArgs e)
        {
            VirtualizationExample virtualizationExample = new VirtualizationExample();
            virtualizationExample.ShowInTaskbar = false;
            virtualizationExample.Owner = Application.Current.MainWindow;
            virtualizationExample.Show();
        }

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

        private void RelativeSource_PeviousData_Click(object sender, RoutedEventArgs e)
        {
            RelativeSource_PreviousData relativeSource_PreviousData = new RelativeSource_PreviousData();
            relativeSource_PreviousData.ShowInTaskbar = false;
            relativeSource_PreviousData.Owner = Application.Current.MainWindow;
            relativeSource_PreviousData.Show();
        }

        private void UpdateSourceTrigger_Default_Click(object sender, RoutedEventArgs e)
        {
            UpdateSourceTrigger_Default updateSourceTrigger_Default = new UpdateSourceTrigger_Default();
            updateSourceTrigger_Default.ShowInTaskbar = false;
            updateSourceTrigger_Default.Owner = Application.Current.MainWindow;
            updateSourceTrigger_Default.Show();
        }

        private void UpdateSourceTrigger_LostFocus_Click(object sender, RoutedEventArgs e)
        {
            UpdateSourceTrigger_LostFocus updateSourceTrigger_LostFocus = new UpdateSourceTrigger_LostFocus();
            updateSourceTrigger_LostFocus.ShowInTaskbar = false;
            updateSourceTrigger_LostFocus.Owner = Application.Current.MainWindow;
            updateSourceTrigger_LostFocus.Show();
        }

        private void UpdateSourceTrigger_PropertyChanged_Click(object sender, RoutedEventArgs e)
        {
            UpdateSourceTrigger_PropetyChanged updateSourceTrigger_PropetyChanged = new UpdateSourceTrigger_PropetyChanged();
            updateSourceTrigger_PropetyChanged.ShowInTaskbar = false;
            updateSourceTrigger_PropetyChanged.Owner = Application.Current.MainWindow;
            updateSourceTrigger_PropetyChanged.Show();
        }

        private void UpdateSourceTrigger_Explicit_Click(object sender, RoutedEventArgs e)
        {
            UpdateSourceTrigger_Explicit updateSourceTrigger_Explicit = new UpdateSourceTrigger_Explicit();
            updateSourceTrigger_Explicit.ShowInTaskbar = false;
            updateSourceTrigger_Explicit.Owner = Application.Current.MainWindow;
            updateSourceTrigger_Explicit.Show();
        }
    }
}
