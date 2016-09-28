using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    /// <summary>
    /// This is were you Interfere with the RESTful web service and pull 
    /// the data from.
    /// </summary>

    public class WeatherDataServiceFactory
    {
        IWeatherDataService exp;  
        const string OPEN_WEATHER_MAP = "OPEN_WEATHER_MAP";
        public static IWeatherDataService GetWeatherDataService(string OPEN_WEATHER_MAP)
        {
            if (OPEN_WEATHER_MAP.Equals("OPEN_WEATHER_MAP"))
            {
                return WeatherMap.Instance();
            }
            return new WeatherData();
        }
    }
}
