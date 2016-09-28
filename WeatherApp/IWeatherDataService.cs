using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is an Interface which displays the functions that are handling 
/// the base functionality of the application
/// </summary>

namespace WeatherApp
{
    public interface IWeatherDataService
    {
        WeatherData GetWeatherData(Location location);
        void PrintDetails();
    }
}


