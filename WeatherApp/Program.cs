using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Program
    {
        /// <summary>
        /// The main core of the application which handels all the classes
        /// and eventually print the details wich the user chosen into the screen
        /// </summary>
     
        static void Main(string[] args)
        {
            string site = "OPEN_WEATHER_MAP";
            // using the site value within the WeatherDataServiceFactory which implemented by the Factory Design Pattern
            IWeatherDataService iw = WeatherDataServiceFactory.GetWeatherDataService(site);
            Console.WriteLine("For weather details, please Enter the name of the required city: \n");
            string locCity = Console.ReadLine(); // location value from the user
            Location locMain = new Location(locCity);
            WeatherData wd = iw.GetWeatherData(locMain);
            wd.PrintDetails();
            Console.ReadKey();
        }
    }
}
