using Keysight.Ccl.Wsl.UI;
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
using System.Windows.Threading;

namespace MVVMCore.DependencyPropertySample
{
    /// <summary>
    /// Interaction logic for DependencyPropertyExample.xaml
    /// </summary>
    public partial class BasicDependencyProperty : WslDialog
    {

        //Syntax of Normal CLR Property
        //Syntax of Dependency Property
        //Syntax of Custom Dependency Property
        //Syntax of Working Dependency Property

        public BasicDependencyProperty()
        {
            InitializeComponent();
            #region Common - Theme & Location

            this.Background = ThemeMgr.ThemeBackgroundColour;
            this.Foreground = ThemeMgr.ThemeForgroundColour;

            #endregion
        }

        #region Syntax of Normal CLR Property
        private int normalCLRProperty;
        public int NormalCLRProperty
        {
            get { return normalCLRProperty; }
            set { normalCLRProperty = value; }
        }
        #endregion

        #region Syntax of Dependency Property
        private int normalDependencyProperty;
        public int NormalDependencyProperty
        {
            get { return normalDependencyProperty; }
            set { normalDependencyProperty = value; }
        }
        #endregion

        #region Syntax of Custom Dependency Property
        public int MyCustomProperty   // CLR Property
        {
            get { return (int)GetValue(CustomDependencyProperty); }
            set { SetValue(CustomDependencyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Counter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomDependencyProperty =
            DependencyProperty.Register("MyCustomProperty", typeof(int), typeof(BasicDependencyProperty), new PropertyMetadata(0));
        #endregion

        #region All the internal dependency properties
        //Button right click ButtonBase right click ContentControl right click Control 

        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.BorderBrush dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.BorderBrush dependency
        ////     property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty BorderBrushProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.PreviewMouseDoubleClick routed
        ////     event.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.PreviewMouseDoubleClick
        ////     routed event.
        public static readonly RoutedEvent PreviewMouseDoubleClickEvent;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.Template dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.Template dependency property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty TemplateProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.Padding dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.Padding dependency property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty PaddingProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.IsTabStop dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.IsTabStop dependency property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty IsTabStopProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.TabIndex dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.TabIndex dependency property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty TabIndexProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.VerticalContentAlignment dependency
        ////     property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.VerticalContentAlignment
        ////     dependency property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty VerticalContentAlignmentProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.HorizontalContentAlignment dependency
        ////     property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.HorizontalContentAlignment
        ////     dependency property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty HorizontalContentAlignmentProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.MouseDoubleClick routed event.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.MouseDoubleClick routed
        ////     event.
        public static readonly RoutedEvent MouseDoubleClickEvent;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.FontStyle dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.FontStyle dependency property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty FontStyleProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.FontStretch dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.FontStretch dependency
        ////     property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty FontStretchProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.FontSize dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.FontSize dependency property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty FontSizeProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.FontFamily dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.FontFamily dependency
        ////     property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty FontFamilyProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.Foreground dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.Foreground dependency
        ////     property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty ForegroundProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.Background dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.Background dependency
        ////     property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty BackgroundProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.BorderThickness dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.BorderThickness dependency
        ////     property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty BorderThicknessProperty;
        ////
        //// Summary:
        ////     Identifies the System.Windows.Controls.Control.FontWeight dependency property.
        ////
        //// Returns:
        ////     The identifier for the System.Windows.Controls.Control.FontWeight dependency
        ////     property.
        //[CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty FontWeightProperty;
        #endregion

    }
}
