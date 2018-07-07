using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
       // GET api/weather
        [HttpGet("Get current weather")]
        public JsonResult GetCurrent()
        {
            var weather = new GetCurrentWeather();
            var result = weather.GetTodayWeather();
            return new JsonResult(result, new JsonSerializerSettings() {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            });
        }

        ////GET api/weather/5
        [HttpGet("Get forecast")]
        public JsonResult GetFiveDays()
        {
            var weather = new ForecastImplementer();
            var result = weather.ForecastGet();
            return new JsonResult(result, new JsonSerializerSettings() { DateFormatHandling = DateFormatHandling.IsoDateFormat });
        }

       
    }
}
