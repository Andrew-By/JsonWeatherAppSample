using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class City
    {
        public City(int id, string name, Coord coord, string country, int population, object sys)
        {
            Id = id;
            Name = name;
            Coord = coord;
            Country = country;
            Population = population;
            Sys = sys;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Coord Coord { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public object Sys { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
