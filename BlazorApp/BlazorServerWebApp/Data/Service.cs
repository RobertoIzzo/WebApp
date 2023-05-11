using BlazorApp.Shared;
using RazorClassLibrary;

namespace BlazorServerWebApp.Data
{
    public class Service : IServices
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<BlazorApp.Shared.WeatherForecast[]?> GetFromJsonAsync()
        {
            DateOnly startDate = new DateOnly();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
