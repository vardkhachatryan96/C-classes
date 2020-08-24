using System;
using System.ComponentModel.DataAnnotations;

namespace WeatherMonitoringStation.DAL.Models
{
    public class Weather
    {
        [Key]
        public int Id { get; set; }

        public string City { get; set; }

        public float Temprature { get; set; }

        public int Pressure { get; set; }

        public int Humadity { get; set; }

        public DateTime Date { get; set; }
    }
}
