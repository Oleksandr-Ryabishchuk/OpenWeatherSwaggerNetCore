using Newtonsoft.Json;
using System;
using System.Net;
using static Api.Models.MyWeather;

namespace Api.Models
{
    public class GetCurrentWeather
    {
        public Object GetTodayWeather()
        {
            var stringData = new WebClient().DownloadString(Base.connectionStringCurrentWeather);
            var currentWeather = JsonConvert.DeserializeObject<CurrentBunch>(stringData);
            var time = UnixTimeStampToDateTime(currentWeather.dt);
            var clouds = currentWeather.clouds;
            var wind = currentWeather.wind;
            var main = currentWeather.main;
            var pressure = HPaToMmWaterColumn(currentWeather.main.Pressure);

            string v = string.Format("Time: {0}, Clouds: {1} %, Wind Speed: {2} meter/sec, Humidity: {3} %, Pressure: {4} millimeters water column, Temperature: {5} °C", time, currentWeather.clouds.all, currentWeather.wind.Speed, currentWeather.main.Humidity, pressure, currentWeather.main.Temp);

            var scope = new Object[] { time, clouds, wind, main };
            return v;
            
        }
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
        public static  double HPaToMmWaterColumn(int hPaPresure)
        {
            double mMWCol = hPaPresure * 10.197162129779;
            return mMWCol;

        }

        
    }
}
