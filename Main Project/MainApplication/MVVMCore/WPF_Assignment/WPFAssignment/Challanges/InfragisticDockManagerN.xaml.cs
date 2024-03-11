using Infragistics.Windows.DockManager;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMCore.Challanges
{
    /// <summary>
    /// Interaction logic for InfragisticDockManager.xaml
    /// </summary>
    public partial class InfragisticDockManagerN : Window
    {
        public InfragisticDockManagerN()
        {
            InitializeComponent();
            x_cbxtheme.IsChecked = ThemeMgr.IsCurrentTheme;
            SkinManager.Instance.SkinChanged += KsWsl_ThemeChanged;
            ApplyTheme();
        }

        private void KsWsl_ThemeChanged(object sender, SkinChangedEventArgs e)
        {
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            dockManager.Background = ThemeMgr.ThemeBackgroundColour;
           // dockManager.Foreground = ThemeMgr.ThemeForegroundColour;
            
            //x_tabGroupHeaderFile1.Background = ThemeMgr.ThemeForegroundColour;
            //x_tabGroupHeaderFile2.Background = ThemeMgr.ThemeForegroundColour;

            //dockManager.Background = ThemeMgr.ThemeBackgroundColour;
            //dockManager.Foreground = ThemeMgr.ThemeForegroundColour;

            x_DocumentContentHost.Background = ThemeMgr.CaranuThemeTabBackgroundColour;
            //x_DocumentContentHost.Foreground = ThemeMgr.ThemeForegroundColour;


            foreach (SplitPane item in x_DocumentContentHost.Panes)
            {
                
                foreach (var item1 in item.Panes)
                {
                    //TabGroupPane tbp = item1 as TabGroupPane;
                    //if (tbp != null)
                    //{
                    //    foreach (ContentPane item2 in tbp.Items)
                    //    {
                    //        if (item2.IsActivePane)
                    //        {
                    //             = Brushes.Red;
                    //        }
                    //        else
                    //        {
                    //            tbp.Background = Brushes.Green;
                    //        }
                    //    }
                    //}
                    //ContentPane cp = item1 as ContentPane;
                    //if (cp != null)
                    //{
                    //        if (cp.IsActivePane)
                    //        {
                    //            cp.Background = ThemeMgr.CaranuThemeTabForegroundColour;
                    //        }
                    //        else
                    //        {
                    //            cp.Background = ThemeMgr.CaranuThemeTabBackgroundColour;
                    //        }
                    //}
                }
            }
        }

        private void CreateTabGroupPane(XamDockManager dockManager)
        {
            SplitPane dockedSplit = new SplitPane();
            dockedSplit.SplitterOrientation = Orientation.Horizontal;
            XamDockManager.SetInitialLocation(dockedSplit, InitialPaneLocation.DockedRight);

            // A TabGroupPane can be hosted within a SplitPane
            TabGroupPane tgpDocked = new TabGroupPane();

            ContentPane cpDockedTab1 = new ContentPane();
            cpDockedTab1.Header = "Solution Explorer";
            cpDockedTab1.Content = new TreeView();
            tgpDocked.Items.Add(cpDockedTab1);

            ContentPane cpDockedTab2 = new ContentPane();
            cpDockedTab2.Header = "Class View";
            cpDockedTab2.Content = new TreeView();
            tgpDocked.Items.Add(cpDockedTab2);
            dockedSplit.Panes.Add(tgpDocked);

            ContentPane cpRightBottom = new ContentPane();
            cpRightBottom.Header = "Properties";
            cpRightBottom.Content = new ListView();
            dockedSplit.Panes.Add(cpRightBottom);

            dockManager.Panes.Add(dockedSplit);

            DocumentContentHost dch = new DocumentContentHost();
            SplitPane dchSplit = new SplitPane();

            // TabGroupPane and SplitPane are the only element 
            // types allowed within a SplitPane in the 
            // DocumentContentHost
            TabGroupPane tgpDch1 = new TabGroupPane();
            ContentPane tgpDchTab1 = new ContentPane();
            tgpDchTab1.Header = "File 1";
            tgpDchTab1.Content = new RichTextBox();
            tgpDch1.Items.Add(tgpDchTab1);
            dchSplit.Panes.Add(tgpDch1);

            TabGroupPane tgpDch2 = new TabGroupPane();
            ContentPane tgpDchTab2 = new ContentPane();
            tgpDchTab2.Header = "File 2";
            tgpDchTab2.Content = new RichTextBox();
            tgpDch2.Items.Add(tgpDchTab2);
            dchSplit.Panes.Add(tgpDch2);

            dch.Panes.Add(dchSplit);

            dockManager.Content = dch;

            
        }

        private void searchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void searchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void columnResizeByContent_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void columnResizeByHeader_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void findPrevPacket_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void findNextPacket_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void filterPackets_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleMarkers_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleMarkers_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleToolTips_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleToolTips_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void DetailsPaneButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void HeaderPaneButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void PayloadPaneButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void LanesPaneButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TrafficOverviewPaneButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ImageViewPaneButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void LtssmOverviewPaneButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TransactionDecodePaneButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TestAssertionPaneButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void PCIePerformanceOverviewPaneButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComparePaneButton_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void ExportButton_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void DockManager_ActivePaneChanged(object sender, RoutedPropertyChangedEventArgs<Infragistics.Windows.DockManager.ContentPane> e)
        {

        }

        private void DockManager_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ContentPaneDetails_Closed(object sender, Infragistics.Windows.DockManager.Events.PaneClosedEventArgs e)
        {

        }

        private void ContentPane_VisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void ContentPaneHeader_Closed(object sender, Infragistics.Windows.DockManager.Events.PaneClosedEventArgs e)
        {

        }

        private void ContentPanePayload_Closed(object sender, Infragistics.Windows.DockManager.Events.PaneClosedEventArgs e)
        {

        }

        private void ContentPaneLanes_Closed(object sender, Infragistics.Windows.DockManager.Events.PaneClosedEventArgs e)
        {

        }

        private void ContentPaneTrafficOverview_Closed(object sender, Infragistics.Windows.DockManager.Events.PaneClosedEventArgs e)
        {

        }

        private void ContentPaneImageView_Closed(object sender, Infragistics.Windows.DockManager.Events.PaneClosedEventArgs e)
        {

        }

        private void ContentPaneLtssmOverview_Closed(object sender, Infragistics.Windows.DockManager.Events.PaneClosedEventArgs e)
        {

        }

        private void ContentPaneTransactionDecode_Closed(object sender, Infragistics.Windows.DockManager.Events.PaneClosedEventArgs e)
        {

        }

        private void ContentPaneTestAssertion_Closed(object sender, Infragistics.Windows.DockManager.Events.PaneClosedEventArgs e)
        {

        }

        private void ContentPanePCIePerformanceOverview_Closed(object sender, Infragistics.Windows.DockManager.Events.PaneClosedEventArgs e)
        {

        }

        private void dockManager_ActivePaneChanged_1(object sender, RoutedPropertyChangedEventArgs<ContentPane> e)
        {
            ApplyTheme();
        }
    }
}
