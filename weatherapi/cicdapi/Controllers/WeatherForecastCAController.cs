using Microsoft.AspNetCore.Mvc;

namespace cicdapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastCAController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastCAController> _logger;

        public WeatherForecastCAController(ILogger<WeatherForecastCAController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecastCA")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
