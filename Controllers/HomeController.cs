using Microsoft.AspNetCore.Mvc;
using WeatherApp.ServiceContracts;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityWeatherService _cityWeatherService;
        public HomeController(ICityWeatherService cityWeatherService)
        {
            _cityWeatherService = cityWeatherService;
        }
        [Route("/")]
        public IActionResult Index()
        {
            return View(_cityWeatherService.CitiesWeather);
        }

        [Route("/weather/{cityCode}")]
        public IActionResult WeatherDetails(string cityCode)
        {
            return View(_cityWeatherService.CitiesWeather.FirstOrDefault(p => p.CityUniqueCode == cityCode));
        }
    }
}
