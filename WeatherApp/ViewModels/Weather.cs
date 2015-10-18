using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.ViewModels
{
    public class Weather
    {
        public Models.Weather WData { get; set; }

        public async Task UpdateWeather()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(new Uri("http://api.openweathermap.org/data/2.5/forecast/city?id=524901&APPID=111111111111"));
            try
            {
                WData = JsonConvert.DeserializeObject(response, typeof(Models.Weather)) as Models.Weather;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
