using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM.WPFMVVMPattern
{
    public class SampleModel
    {
        public string CurrentName { get; set; }

        public ObservableCollection<string> AddedNames { get; } = new ObservableCollection<string>();
    }
}
