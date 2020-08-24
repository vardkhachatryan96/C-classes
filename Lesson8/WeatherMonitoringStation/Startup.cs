using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeatherMonitoringStation.BL.Api;
using WeatherMonitoringStation.BL.Services;
using WeatherMonitoringStation.DAL;
using WeatherMonitoringStation.DAL.Api;
using WeatherMonitoringStation.DAL.Repositories;

namespace WeatherMonitoringStation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            
            services.AddDbContext<WeatherMonitoringStationDbContext>(options => 
                                options.UseSqlServer(this.Configuration.GetConnectionString("dbConnection")));

            services.AddScoped<IWeatherInformationService, WeatherInformationService>();
            services.AddScoped<IWeatherInformationRepository, WeatherInformationRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
