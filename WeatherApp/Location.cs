using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Location
    {
    /// <summary>
    /// The location is handling all the parameters about the chosen input 
    /// </summary>
        private string city;
        private string temprature;
        private string humadity;
        private string pressure;
        private string wind;
        private string clouds;
        private string visibility;
        private string weather;
        private string lastupdate;
        public Location() { }
        public Location(string city) { this.city = city; }
        
        public Location(string city, string temprature, string humadity, string pressure, string wind, string clouds, string visibility, string weather, string lastupdate)
        {
            this.city = city;
            this.temprature = temprature;
            this.humadity = humadity;
            this.pressure = pressure;
            this.wind = wind;
            this.clouds = clouds;
            this.visibility = visibility;
            this.weather = weather;
            this.lastupdate = lastupdate;
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Humadity
        {
            get
            {
                return humadity;
            }
            set
            {
                humadity = value;
            }
        }

        public string Temprature
        {
            get
            {
                return temprature;
            }
            set
            {
                temprature = value;
            }
        }

        public string Pressure
        {
            get
            {
                return pressure;
            }
            set
            {
                pressure = value;
            }
        }

        public string Wind
        {
            get
            {
                return wind;
            }
            set
            {
                wind = value;
            }
        }

        public string Clouds
        {
            get
            {
                return clouds;
            }
            set
            {
                clouds = value;
            }
        }

        public string Visibility
        {
            get
            {
                return visibility;
            }
            set
            {
                visibility = value;
            }
        }

        public string Weather
        {
            get
            {
                return weather;
            }
            set
            {
                weather = value;
            }
        }

        public string Lastupdate
        {
            get
            {
                return lastupdate;
            }
            set
            {
                lastupdate = value;
            }
        }
        


    }
}
