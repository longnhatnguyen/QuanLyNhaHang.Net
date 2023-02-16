using Microsoft.AspNetCore.Mvc;

namespace QLNH.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return null;
        }
    }
}
