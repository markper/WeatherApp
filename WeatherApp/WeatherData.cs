using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This class gets the details from a RESTful Web Service and handles
/// the data by sending it to the PrintDetails function
/// </summary>

namespace WeatherApp
{
    public class WeatherData : IWeatherDataService
    { 
        private Location location;

        public Location Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public WeatherData() {
            this.location = new Location();
        }
        
        /// <summary>
        /// PrintDetails prints all the data about the chosen input
        /// </summary>
        public void PrintDetails()
        {
            Console.WriteLine("City: "+Location.City+ "\n"+"Temprature: "+Location.Temprature+" Celsius"+"\n"+"Humadity: "+Location.Humadity+"\n"+ "Pressure: "+Location.Pressure + "\n" + "Wind: " + Location.Wind + "\n" + "Clouds: " + Location.Clouds + "\n" + "Visibility: " + Location.Visibility + "\n" + "Weather: " + Location.Weather + "\n" + "Lastupdate: " + Location.Lastupdate + "\n");
        }
 
       virtual public WeatherData GetWeatherData(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
