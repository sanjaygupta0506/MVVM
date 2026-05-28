using Keysight.Ccl.Wsl.UI;
using Newtonsoft.Json;
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

namespace MainApplication.WPF_MVVM._6._API.Web_API
{
    /// <summary>
    /// Interaction logic for WPFWithWebAPI.xaml
    /// </summary>
    public partial class WPFWithWebAPI : WslDialog
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public WPFWithWebAPI()
        {
            InitializeComponent();
        }

        private async void btnFetchData_Click(object sender, RoutedEventArgs e)
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts"; // Sample API

            try
            {
                var data = await FetchDataAsync(apiUrl);
                DataListBox.ItemsSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task<List<Post>> FetchDataAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string jsonData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Post>>(jsonData);
            }
            else
            {
                throw new Exception("API call failed");
            }
        }

    }

        public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public override string ToString() => Title; // Display title in ListBox
}

}
