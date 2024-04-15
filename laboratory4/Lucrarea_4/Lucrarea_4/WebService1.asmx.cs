using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lucrarea_4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public double FahrenheitToCelsius(double temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) * 5 / 9;
        }

        [WebMethod]
        public List<string> GetList()
        {

            return new List<string> { "Tricou", "Bluza", "Pantaloni", "Camasa", "Papuci" };
        }


        [WebMethod]
        public double CelsiusToFahrenheit(double temperatureCelsius)
        {
            return (temperatureCelsius * 9 / 5) + 32;
        }

        [WebMethod]
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }

        [WebMethod]
        public double ConvertCurrencyToEuro(double amountInRON)
        {
            return amountInRON / 4.97; 
        }
    }
}
