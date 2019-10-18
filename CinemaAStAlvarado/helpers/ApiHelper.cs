using Newtonsoft.Json;
using System;
using System.Net.Http;
using Xamarin.Forms;

namespace CinemaAStAlvarado.helpers
{
    public static class ApiHelper
    {
        public static T Get<T>(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://misapis.azurewebsites.net/api/Cartelera");

            var request = client.GetAsync(url).Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<T>(responseJson);

                return response;
            }

            return default(T);
        }
    }
}