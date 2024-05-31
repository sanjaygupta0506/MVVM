using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM._2._WPFMVVMAdvance.DependencyPropertySample
{
    class BasicDependencyPropertyViewModel : BindableBase
    {
        #region Properties  
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set => SetProperty(ref _userName, value);
        }
        #endregion
    }
}
