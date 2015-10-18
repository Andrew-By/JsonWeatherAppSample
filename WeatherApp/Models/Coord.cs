using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Coord
    {
        public Coord(double lon, double lat)
        {
            Lon = lon;
            Lat = lat;
        }
        public double Lon { get; set; }
        public double Lat { get; set; }
    }
}
