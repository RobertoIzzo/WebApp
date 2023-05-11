using System.Net.Http.Json;
using BlazorApp.Shared;
using RazorClassLibrary;
using static System.Net.WebRequestMethods;

namespace BlazorApp.Client
{
    public class Service :IServices
    {
        private readonly HttpClient _http;

        public Service(HttpClient http)
        {
            _http = http;
        }
        public Task<BlazorApp.Shared.WeatherForecast[]?> GetFromJsonAsync()
        {
          return  _http.GetFromJsonAsync<WeatherForecast[]?>("WeatherForecast");
        }
    }
}
