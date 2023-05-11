using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorApp.Shared;
using static System.Net.WebRequestMethods;

namespace RazorClassLibrary
{
    public interface IServices
    {
        Task<WeatherForecast[]?> GetFromJsonAsync();
    }
}
