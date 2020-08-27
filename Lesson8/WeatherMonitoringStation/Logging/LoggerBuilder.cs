using log4net;
using System;

namespace WeatherMonitoringStation.Logging
{
    public class LoggerBuilder
    {
        public static ILog Get(Type type)
        {
            return LogManager.GetLogger(type ?? typeof(LoggerBuilder));
        }
    }
}
