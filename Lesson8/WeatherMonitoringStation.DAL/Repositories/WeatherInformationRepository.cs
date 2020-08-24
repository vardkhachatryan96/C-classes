using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherMonitoringStation.DAL.Api;

namespace WeatherMonitoringStation.DAL.Repositories
{
    public class WeatherInformationRepository : IWeatherInformationRepository
    {
        private readonly WeatherMonitoringStationDbContext context;

        public WeatherInformationRepository(WeatherMonitoringStationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<float>> GetCityTemperatures(string city, DateTime from, DateTime to)
        {
            return await context.WeatherInformation.Where(w => w.City == city && (w.Date >= from && w.Date <= to))
                                             .Select(s=>s.Temprature)
                                             .ToListAsync();
        }
    }
}
