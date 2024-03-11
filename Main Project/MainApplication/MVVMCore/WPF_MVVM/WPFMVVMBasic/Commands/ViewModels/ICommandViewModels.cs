using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MainApplication;

namespace MainApplication.WPF_MVVM.WPFMVVMBasic.Commands.ViewModels
{
    public class ICommandViewModels : ObservableObject
    {
        private PageId _pageID;

        public PageId PageID
        {
            get { return _pageID; }
            set { SetProperty(ref _pageID, value); }
        }

        public ICommand CMDChangePage => new RelayCommand<PageId>(ChangePage);
        void ChangePage(PageId newPage)
        {
            PageID = newPage;
        }

        public ICommandViewModels() { PageID = PageId.A; }

    }
}
