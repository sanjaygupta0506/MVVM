using MainApplication.WPF_MVVM._6._API.Rest_API.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM._6._API.Rest_API.Service
{
    class PostService
    {
        private readonly HttpClient _httpClient;
        public PostService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<PostModel>> GetUsersAsync()
        {
            string url = "https://jsonplaceholder.typicode.com/albums";
            var response = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<List<PostModel>>(response);
        }
    }
}
