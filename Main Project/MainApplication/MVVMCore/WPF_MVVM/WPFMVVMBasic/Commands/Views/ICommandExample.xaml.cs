using Keysight.Ccl.Wsl.UI;
using MainApplication.WPF_MVVM.WPFMVVMBasic.Commands.ViewModels;
using System.Windows;

namespace MainApplication.WPF_MVVM.WPFMVVMBasic.Commands.Pages
{
    /// <summary>
    /// Interaction logic for ICommandExample.xaml
    /// </summary>
    public partial class ICommandExample : WslDialog
    {
        public ICommandExample()
        {
            this.DataContext = new ICommandViewModels();
            InitializeComponent();
        }
    }
}
