using Keysight.Ccl.Wsl.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace MainApplication.WPF_MVVM._6._API.Rest_API
{
   
    /// <summary>
    /// Interaction logic for WPFRestAPI.xaml
    /// </summary>
    public partial class WPFRestAPI : WslDialog
    {
        private readonly HttpClient _httpClient;
        public WPFRestAPI()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private async void FetchData_Click(object sender, RoutedEventArgs e)
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts/1"; // Sample API

            try
            {
                string response = await FetchDataAsync(apiUrl);
                ResultTextBlock.Text = response;
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = $"Error: {ex.Message}";
            }
        }

        private async Task<string> FetchDataAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }

}
