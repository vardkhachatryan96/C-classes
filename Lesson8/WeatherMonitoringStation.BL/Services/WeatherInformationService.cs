using System;
using System.Linq;
using System.Threading.Tasks;
using WeatherMonitoringStation.BL.Api;
using WeatherMonitoringStation.DAL.Api;

namespace WeatherMonitoringStation.BL.Services
{
    public class WeatherInformationService : IWeatherInformationService
    {
        private readonly IWeatherInformationRepository weatherInformationRepository;

        public WeatherInformationService(IWeatherInformationRepository weatherInformationRepository)
        {
            this.weatherInformationRepository = weatherInformationRepository;
        }

        public async Task<float> GetCityAverageTemp(string city, DateTime from, DateTime to)
        {
            var result = await this.weatherInformationRepository.GetCityTemperatures(city, from, to);

            if (result.Count == 0)
            {
                return 0;
            }

            return result.Average();
        }
    }
}
