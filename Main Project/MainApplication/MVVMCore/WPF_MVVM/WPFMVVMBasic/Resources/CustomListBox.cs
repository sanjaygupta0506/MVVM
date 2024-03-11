using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;


namespace MainApplication.WPF_MVVM.WPFMVVMBasic.Resources
{
    public class CustomListBox: ListBox
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                e.Handled = true;
            else
                base.OnKeyDown(e);
        }
    }
}
