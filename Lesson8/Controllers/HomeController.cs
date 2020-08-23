using Lesson8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson8.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly CacheController cacheController;

        public HomeController(IConfiguration config, CacheController cacheController)
        {
            this.config = config;
            this.cacheController = cacheController;
        }
        private static readonly HttpClient client = new HttpClient();

        [HttpGet("{city}")]
        public async Task<JsonResult> GetCurWeatherOf(string city)
        {
            var key = config.GetValue<string>("ApiKey");
            if (cacheController.GetCache("CurrWeather") != Ok())
            {

            }
            var streamTask = client.GetStreamAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}");
            var response = await JsonSerializer.DeserializeAsync<WeatherModel>(await streamTask);

            var result = new JsonResult(new CurrentWeatherModel
            {
                CityName = response.name,
                Humadity = response.main.humidity,
                Temprature = response.main.temp,
                Pressure = response.main.pressure
            });

            cacheController.SetCache("CurrWeather", result);

            return result;
        }
    }
}
