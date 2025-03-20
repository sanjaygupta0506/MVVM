//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM._6._API.Web_API
{
    public class WPFMVVMWebAPIViewModel : INotifyPropertyChanged
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private const string ApiUrl = "https://jsonplaceholder.typicode.com/posts";

        public ObservableCollection<Post> Posts { get; set; } = new ObservableCollection<Post>();

        public event PropertyChangedEventHandler PropertyChanged;

        public WPFMVVMWebAPIViewModel()
        {
            _ = LoadPostsAsync();
        }

        private async Task LoadPostsAsync()
        {
            var response = await _httpClient.GetStringAsync(ApiUrl);
            var posts = JsonSerializer.Deserialize<List<Post>>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (posts != null)
            {
                foreach (var post in posts)
                    Posts.Add(post);
            }
        }
    }
}
