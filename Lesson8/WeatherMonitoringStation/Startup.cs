using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Reflection;
using WeatherMonitoringStation.BL.Api;
using WeatherMonitoringStation.BL.Services;
using WeatherMonitoringStation.DAL;
using WeatherMonitoringStation.DAL.Api;
using WeatherMonitoringStation.DAL.Repositories;
using WeatherMonitoringStation.Logging;

namespace WeatherMonitoringStation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            this.LoadLogConfigs(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            services.AddScoped(s => LoggerBuilder.Get(GetType()));
            services.AddControllers();
            services.AddDbContext<WeatherMonitoringStationDbContext>(options =>
                                options.UseSqlServer(this.Configuration.GetConnectionString("dbConnection")));

            services.AddScoped<IWeatherInformationService, WeatherInformationService>();
            services.AddScoped<IWeatherInformationRepository, WeatherInformationRepository>();
        }

        private void LoadLogConfigs(string executionDir)
        {
            // Log config path
            var logConfigPath = Path.Combine(executionDir, this.Configuration.GetValue<string>("LOG_CONFIG_NAME"));
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo(logConfigPath));
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
