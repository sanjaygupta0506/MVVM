using MainApplication.WPF_MVVM._6._API.Model;
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
    public class UserViewModel : INotifyPropertyChanged
    {
        private readonly UserService _apiService = new UserService();

        private ObservableCollection<UserModel> _users;

        public UserViewModel()
        {
            LoadUsers();
        }
        public ObservableCollection<UserModel> Users
        {
            get => _users;
            set { _users = value; OnPropertyChanged(); }
        }

        private async void LoadUsers()
        {
            var users = await _apiService.GetUsersAsync();
            Users = new ObservableCollection<UserModel>(users);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
