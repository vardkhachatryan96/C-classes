using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherMonitoringStation.BL.Api;
using WeatherMonitoringStation.Log;
using WeatherMonitoringStation.Mappers;
using WeatherMonitoringStation.Models.JsonModel;

namespace WeatherMonitoringStation.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherStationController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly ILog log = LoggerBuilder.Get(MethodBase.GetCurrentMethod()?.DeclaringType);

        private readonly IConfiguration config;
        private readonly IWeatherInformationService weatherInformationService;

        public WeatherStationController(IConfiguration config, IWeatherInformationService weatherInformationService)
        {
            this.config = config;
            this.weatherInformationService = weatherInformationService;
        }

        [HttpGet("{city}")]
        public async Task<JsonResult> GetCurWeatherOf(string city)
        {
            var key = config.GetValue<string>("apiKey");
            var response = new WeatherJsonModel();
            try
            {
                var streamTask = client.GetStreamAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}");
                response = await JsonSerializer.DeserializeAsync<WeatherJsonModel>(await streamTask);
            }
            catch (Exception ex)
            {
                this.log.Error(ex);
            }

            this.log.Info($"Successfully completed getting current weather info of {city}");
            return new JsonResult(CurrentWeatherMapper.Map(response));
        }

        [HttpGet("{city}/{from}/{to}")]
        public async Task<JsonResult> GetAverageTempOf(string city, string from, string to)
        {
            if (!DateTime.TryParse(from, out var dateTimeFrom))
            {
                this.log.Error("The from parameter is not in correct format");
                return new JsonResult("Bad Request: The specified start date parameter is not in correct format");
            }
            
            if (!DateTime.TryParse(to, out var dateTimeTo))
            {
                this.log.Error("The to parameter is not in correct format");
                return new JsonResult("Bad Request: The specified end date parameter is not in correct format");
            }

            this.log.Info($"Successfully completed getting average temprature of {city} from {dateTimeFrom} to {dateTimeTo}");
            var result = await this.weatherInformationService.GetCityAverageTemp(city, dateTimeFrom, dateTimeTo);

            return new JsonResult($"The average temprature of {city} from {dateTimeFrom} to {dateTimeTo} is: {result}");
        }
    }
}
