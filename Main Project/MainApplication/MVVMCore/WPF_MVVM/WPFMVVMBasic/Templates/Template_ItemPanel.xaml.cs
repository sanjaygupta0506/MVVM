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
    /// Interaction logic for ItemTemplateExample.xaml
    /// </summary>
    public partial class Template_ItemPanel : WslDialog
    {
        public Template_ItemPanel()
        {
            InitializeComponent();

            // Create the Collection  
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book()
            {
                CoverImage = @"D:\Personal\MVVM\Main Project\MainApplication\MVVMCore\WPF_MVVM\Images\New.png",
                Name = ".Net with WPF",
                Author = "Sanjay Gupta"
            });
            bookList.Add(new Book()
            {
                CoverImage = @"D:\Personal\MVVM\Main Project\MainApplication\MVVMCore\WPF_MVVM\Images\openHS.png",
                Name = "Software Engineering",
                Author = "Deepak Jain"
            });
            bookList.Add(new Book()
            {
                CoverImage = @"D:\Personal\MVVM\Main Project\MainApplication\MVVMCore\WPF_MVVM\Images\power_on.png",
                Name = "HTML 5",
                Author = "Adam McDaniel"
            });
            bookList.Add(new Book()
            {
                CoverImage = @"D:\Personal\MVVM\Main Project\MainApplication\MVVMCore\WPF_MVVM\Images\search_light.png",
                Name = "Visual Studio 2015",
                Author = "Lars Powers"
            });
            //Bind it with the ListBox  
            this.itemTemplate.ItemsSource = bookList;
        }
    }


    public class Book
    {
        public string CoverImage
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
    }
}
