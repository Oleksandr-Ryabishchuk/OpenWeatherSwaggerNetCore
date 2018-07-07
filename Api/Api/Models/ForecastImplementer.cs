using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using static Api.Models.ForecastBase;

namespace Api.Models
{
    public class ForecastImplementer
    {


        public List<Object> ForecastGet()
        {
            var stringData = new WebClient().DownloadString(Base.connectionStringForeCast);
            var fiveWeather = JsonConvert.DeserializeObject<Example>(stringData);

            List<Object> w = new List<object>();


            for (int i = 0; i < fiveWeather.list.Count; i++)
            {
               string m =  string.Format("Time: {0}," +
               " Clouds: {1} %," +
               " Wind Speed: {2} meter/sec," +
               " Humidity: {3} %," +
               " Pressure: {4} millimeters water column," +
               " Temperature: {5} °C",
               fiveWeather.list[i].dt_txt,
               fiveWeather.list[i].clouds.all,
               fiveWeather.list[i].wind.speed,
               fiveWeather.list[i].main.humidity,
               fiveWeather.list[i].main.pressure * 10.197162129779,
               fiveWeather.list[i].main.temp);
               w.Add(m);
            };
            


                return w;

            }
        }
    }

