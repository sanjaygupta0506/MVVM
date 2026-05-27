using MainApplication.WPF_MVVM._6._API.Rest_API.Model;
using MainApplication.WPF_MVVM._6._API.Rest_API.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM._6._API.Rest_API.ViewModel
{
    class PostViewModel : INotifyPropertyChanged
    {
        private readonly PostService _apiService = new PostService();

        private ObservableCollection<PostModel> _posts;

        public PostViewModel()
        {
            LoadUsers();
        }
        public ObservableCollection<PostModel> Posts
        {
            get => _posts;
            set { _posts = value; OnPropertyChanged(); }
        }

        private async void LoadUsers()
        {
            var posts = await _apiService.GetUsersAsync();
            Posts = new ObservableCollection<PostModel>(posts);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
