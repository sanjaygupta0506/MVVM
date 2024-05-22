using Keysight.Ccl.Wsl.UI;
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

namespace MainApplication.WPF_MVVM.WPFMVVMBasic.Templates
{
    /// <summary>
    /// Interaction logic for Template_HierarchialData.xaml
    /// </summary>
    public partial class Template_HierarchialData : WslDialog
    {
        public Template_HierarchialData()
        {
            InitializeComponent();
            var parent1 = new Parent("Parent #1")
            {
                ChildItems = {
                                new Child("Child Item #1.1"),
                                new Child("Child Item #1.2"),
                                new Child("Child Item #1.3")
            }
            };
            var parent2 = new Parent("Parent #2")
            {
                ChildItems = {
                                new Child("Child Item #2.1"),
                                new Child("Child Item #2.2"),
                                new Child("Child Item #2.3")
                             }
            };
            this.treeView.Items.Clear();
            List<Parent> parent = new List<Parent>();
            parent.Add(parent1);
            parent.Add(parent2);
            
            //treeView.Items.Add(parent);

            treeView.ItemsSource = parent;
        }
    }

    public class Child
    {
        public Child(string title)
        {
            Title = title;
        }
        public string Title
        {
            get;
            set;
        }
    }

    public class Parent
    {
        public Parent(string title)
        {
            Title = title;
            ChildItems = new List<Child>();
        }
        public string Title
        {
            get;
            set;
        }
        public List<Child> ChildItems
        {
            get;
            set;
        }


    }
}
