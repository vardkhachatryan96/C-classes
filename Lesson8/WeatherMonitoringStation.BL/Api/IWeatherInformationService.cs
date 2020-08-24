using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringStation.BL.Api
{
    public interface IWeatherInformationService
    {
        /// <summary>
        /// Get average temperature of a city for specified time period
        /// </summary>
        /// <param name="city"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public Task<float> GetCityAverageTemp(string city, DateTime from, DateTime to);
    }
}
