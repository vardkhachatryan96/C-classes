using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WeatherMonitoringStation.DAL.Api
{
    public interface IWeatherInformationRepository
    {
        /// <summary>
        /// Get temperatures of a city for specified time period
        /// </summary>
        /// <param name="city"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public Task<List<float>> GetCityTemperatures(string city, DateTime from, DateTime to);
    }
}
