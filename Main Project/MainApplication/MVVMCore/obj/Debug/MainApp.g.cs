#pragma checksum "..\..\MainApp.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9DF1C751E725D901C6DAA207F42F218110155DF42E6D1E8390E534849DDFFBE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MVVMCore;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MVVMCore {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\MainApp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu x_MainMenu;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainApp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MVVMCore;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainApp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DataBindings;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainApp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Resources;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainApp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem INotifyPropertyChanged;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainApp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DataContext;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainApp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ValueConvertors;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainApp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Commands;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainApp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Styles;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainApp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Triggers;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainApp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Templates;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MVVMCore;component/mainapp.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainApp.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.x_MainMenu = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            this.MVVMCore = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            this.DataBindings = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\MainApp.xaml"
            this.DataBindings.Click += new System.Windows.RoutedEventHandler(this.DataBindings_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Resources = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\MainApp.xaml"
            this.Resources.Click += new System.Windows.RoutedEventHandler(this.Resources_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.INotifyPropertyChanged = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 6:
            this.DataContext = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 7:
            this.ValueConvertors = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 8:
            this.Commands = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 9:
            this.Styles = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 10:
            this.Triggers = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 11:
            this.Templates = ((System.Windows.Controls.MenuItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

