using System;

namespace WeatherMonitoringStation.Models
{
    public class CurrentWeatherModel
    {
        public string CityName { get; set; }

        public float? Temperature { get; set; }

        public int? Pressure { get; set; }

        public int? Humadity { get; set; }

        public DateTime Date { get; set; }
    }
}
