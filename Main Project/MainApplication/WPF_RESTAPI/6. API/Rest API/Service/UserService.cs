using MainApplication.WPF_MVVM._6._API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;




namespace MainApplication.WPF_MVVM._6._API.Rest_API.Service
{
    class UserService
    {
        private readonly HttpClient _httpClient;
        public UserService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<UserModel>> GetUsersAsync()
        {
            string url = "https://jsonplaceholder.typicode.com/users";
            var response = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<List<UserModel>>(response);
        }
    }
}
