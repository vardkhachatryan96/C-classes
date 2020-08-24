using log4net;
using System;

namespace WeatherMonitoringStation.Log
{
    /// <summary>
    /// Log builder
    /// </summary>
    public static class LoggerBuilder
    {
        /// <summary>
        ///  Logging declaration
        /// </summary>
        public static ILog Get(Type type)
        {
            // creates logger
            return LogManager.GetLogger(type ?? typeof(LoggerBuilder));
        }
    }
}
