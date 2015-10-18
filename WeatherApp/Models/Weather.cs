using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Weather
    {
        public Weather(City city, string cod, string message, int cnt, object list)
        {
            City = city;
            Cod = cod;
            Message = message;
            List = list;
        }
        public City City { get; set; }
        public string Cod { get; set; }
        public string Message { get; set; }
        public int Cnt { get; set; }
        public object List { get; set; }
    }
}
