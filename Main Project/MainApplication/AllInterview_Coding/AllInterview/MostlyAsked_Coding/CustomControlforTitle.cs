using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MainApplication.AllInterview_Coding
{
    public class CustomControlforTitle : Control
    {


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title), 
                typeof(string), 
                typeof(CustomControlforTitle), 
                new PropertyMetadata("Default Title"));




        public string EmployeeName
        {
            get { return (string)GetValue(EmployeeNameProperty); }
            set { SetValue(EmployeeNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EmployeeName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeeNameProperty =
            DependencyProperty.Register(
                nameof(EmployeeName), 
                typeof(string), 
                typeof(CustomControlforTitle), 
                new PropertyMetadata("Default EmploeeName"));








    }
}
