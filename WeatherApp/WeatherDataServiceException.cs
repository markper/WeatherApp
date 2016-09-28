using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WeatherApp
{
    /// <summary>
    /// an Exception which being thrown if a wrong string of info
    /// being accepted from the XML, this is being used within WeatherMap class.
    /// </summary>

    public class WeatherDataServiceException : ApplicationException
    {
        public WeatherDataServiceException(string exception) : base (exception)
        {

        }
    }
}
