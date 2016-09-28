using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net;

namespace WeatherApp
{
    /// <summary>
    /// WeatherMap is a class which handels the parsing from the XML
    /// it creates one instance only (using a singleton) 
    /// </summary>

    public class WeatherMap : WeatherData, IWeatherDataService
    {
        private static WeatherMap weatherMap;
        const double celcUnit = -273.15;
        private string urlXML = "http://api.openweathermap.org/data/2.5/weather?q=";
        private const string apiKey = "8180d74caf4d1019b7fe378496fef5f0";

        public WeatherMap() : base() { }

        /// <summary>
        /// a static constructor implimented by the Singelton design pattern
        /// </summary>

        public static WeatherMap Instance()
        {
            if (weatherMap == null)
            {
                return new WeatherMap();
            }
            else
            {
                return weatherMap;
            }

        }

        /// <summary>
        /// parsing from RESTful web service the chosen location
        /// </summary>

        public override WeatherData GetWeatherData(Location location)
        {
            location.City = location.City;
            XMLFunction(this, location);
            return this;
        }

        /// <summary>
        /// the XMLFunction is handeling the parsing from 
        /// the RESTful web service
        /// </summary>

        public void XMLFunction(WeatherMap weatherData, Location location)
        {
            urlXML += location.City + "&mode=xml&appid=" + apiKey;
            WebClient client = new WebClient();
            XDocument xmlDoc;
            string xml;
            try { xml = client.DownloadString(urlXML); }
            catch (WebException) { throw new WeatherDataServiceException("Wrong String of info"); }
            try
            {
                xmlDoc = XDocument.Parse(xml);
                weatherData.Location.City = xmlDoc.Descendants("city").Attributes("name").First().Value;
                weatherData.Location.Temprature = Convert.ToString(Convert.ToDouble(xmlDoc.Descendants("temperature").Attributes("value").First().Value)+celcUnit);
                weatherData.Location.Humadity = xmlDoc.Descendants("humidity").Attributes("value").First().Value + " " + xmlDoc.Descendants("humidity").Attributes("unit").First().Value;
                weatherData.Location.Pressure = xmlDoc.Descendants("pressure").Attributes("value").First().Value + " " + xmlDoc.Descendants("pressure").Attributes("unit").First().Value;
                weatherData.Location.Wind = xmlDoc.Descendants("speed").Attributes("value").First().Value;
                weatherData.Location.Clouds = xmlDoc.Descendants("clouds").Attributes("name").First().Value;
                weatherData.Location.Visibility = xmlDoc.Descendants("visibility").Attributes("value").First().Value;
                weatherData.Location.Weather = xmlDoc.Descendants("weather").Attributes("value").First().Value;
                weatherData.Location.Lastupdate = xmlDoc.Descendants("lastupdate").Attributes("value").First().Value;
            }
            catch
            {

            }
    }
    }
}
