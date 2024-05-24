using Keysight.Ccl.Wsl.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace MainApplication.WPF_MVVM._1._WPFMVVMBasic.RelativeSource
{
    /// <summary>
    /// Interaction logic for RelativeSource_PreviousData.xaml
    /// </summary>
    public partial class RelativeSource_PreviousData : WslDialog
    {
        public RelativeSource_PreviousData()
        {
            InitializeComponent();
            this.DataContext = new Items();
        }
    }

    public class Items : ObservableCollection<Item>
    {
        public Items()
        {
            Add(new Item { Value = 80.23 });
            Add(new Item { Value = 126.17 });
            Add(new Item { Value = 130.21 });
            Add(new Item { Value = 115.28 });
            Add(new Item { Value = 131.21 });
            Add(new Item { Value = 135.22 });
            Add(new Item { Value = 120.27 });
            Add(new Item { Value = 110.25 });
            Add(new Item { Value = 90.20 });
        }
    }

    public class Item : INotifyPropertyChanged
    {
        private double _value;

        public double Value
        {
            get { return _value; }
            set { _value = value; OnPropertyChanged("Value"); }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        protected void OnPropertyChanged(string PropertyName)
        {
            if (null != PropertyChanged)
            {
                PropertyChanged(this,
                     new PropertyChangedEventArgs(PropertyName));
            }
        }
    }

}
