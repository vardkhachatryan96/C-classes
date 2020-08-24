using System;
using WeatherMonitoringStation.Models;
using WeatherMonitoringStation.Models.JsonModel;

namespace WeatherMonitoringStation.Mappers
{
    public class CurrentWeatherMapper
    {
        public static CurrentWeatherModel Map(WeatherJsonModel model)
        {
            return new CurrentWeatherModel
            {
                CityName = model.name ?? string.Empty,
                Humadity = model?.main?.humidity,
                Temperature = model?.main?.temp,
                Pressure = model?.main?.pressure,
                Date = DateTime.Now
            };
        }
    }
}
