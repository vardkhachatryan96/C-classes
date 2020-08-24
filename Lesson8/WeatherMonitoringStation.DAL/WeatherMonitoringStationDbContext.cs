using Microsoft.EntityFrameworkCore;
using System;
using WeatherMonitoringStation.DAL.Models;

namespace WeatherMonitoringStation.DAL
{
    public class WeatherMonitoringStationDbContext : DbContext
    {
        public WeatherMonitoringStationDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Weather> WeatherInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Weather>().HasData(
                new Weather { Id = 1, City = "London", Temprature = 294.45f, Pressure = 1017, Humadity = 56, Date = new DateTime(2020, 8, 17) },
                new Weather { Id = 2, City = "London", Temprature = 294.44f, Pressure = 1018, Humadity = 53, Date = new DateTime(2020, 8, 18) },
                new Weather { Id = 3, City = "London", Temprature = 290.44f, Pressure = 1019, Humadity = 45, Date = new DateTime(2020, 8, 19) },
                new Weather { Id = 4, City = "London", Temprature = 291.43f, Pressure = 1010, Humadity = 52, Date = new DateTime(2020, 8, 20) },
                new Weather { Id = 5, City = "London", Temprature = 294.30f, Pressure = 1011, Humadity = 57, Date = new DateTime(2020, 8, 21) },
                new Weather { Id = 6, City = "London", Temprature = 293.44f, Pressure = 1012, Humadity = 35, Date = new DateTime(2020, 8, 22) },
                new Weather { Id = 7, City = "London", Temprature = 292.44f, Pressure = 1012, Humadity = 65, Date = new DateTime(2020, 8, 23) },
                new Weather { Id = 8, City = "New York", Temprature = 294.45f, Pressure = 1017, Humadity = 56, Date = new DateTime(2020, 8, 17) },
                new Weather { Id = 9, City = "New York", Temprature = 294.44f, Pressure = 1018, Humadity = 53, Date = new DateTime(2020, 8, 18) },
                new Weather { Id = 10, City = "New York", Temprature = 290.44f, Pressure = 1019, Humadity = 45, Date = new DateTime(2020, 8, 19) },
                new Weather { Id = 11, City = "New York", Temprature = 291.43f, Pressure = 1010, Humadity = 52, Date = new DateTime(2020, 8, 20) },
                new Weather { Id = 12, City = "New York", Temprature = 294.30f, Pressure = 1011, Humadity = 57, Date = new DateTime(2020, 8, 21) },
                new Weather { Id = 13, City = "New York", Temprature = 293.44f, Pressure = 1012, Humadity = 35, Date = new DateTime(2020, 8, 22) },
                new Weather { Id = 14, City = "New York", Temprature = 292.44f, Pressure = 1012, Humadity = 65, Date = new DateTime(2020, 8, 23) });
        }
    }
}
