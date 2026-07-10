using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MainApplication.AllInterview_Coding
{
    public class CustomLabelControl : Control
    {
        static CustomLabelControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomLabelControl), new FrameworkPropertyMetadata(typeof(CustomLabelControl)));
        }


        public string LableText
        {
            get { return (string)GetValue(LableTextProperty); }
            set { SetValue(LableTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LableText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LableTextProperty =
            DependencyProperty.Register("LableText", typeof(string), typeof(CustomLabelControl), new PropertyMetadata(string.Empty));



    }
}
