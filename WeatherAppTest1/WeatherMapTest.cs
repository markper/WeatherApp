using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppT
{
    /// <summary>
    /// This class is testing the use of fuctions from the interface
    /// </summary>

    [TestClass()]
    public class WeatherMapTest
    {
        [TestMethod()]
        public void GetWeatherData()
        {
            Location location = new Location("New York");
            WeatherMap wm = WeatherMap.Instance();
            WeatherData wd = wm.GetWeatherData(location);
            Assert.AreEqual(location.City, wd.Location.City);
        }

        [TestMethod()]
        public void PrintDetails()
        {
            Location location = new Location("New York");
            WeatherData wm = WeatherMap.Instance();
            checked { wm.PrintDetails(); } // checks that function initialized  
        }
    }
}
