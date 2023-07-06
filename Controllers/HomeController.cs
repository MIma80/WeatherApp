using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        public List<CityWeather> weatherList = new List<CityWeather>
        {
            new CityWeather
            {
                CityUniqueCode = "LDN",
                CityName = "London",
                DateAndTime = DateTime.Parse("2030-01-01 3:00"),
                TemperatureFahrenheit = 32
            },
            new CityWeather
            {
                CityUniqueCode = "PAR",
                CityName = "Paris",
                DateAndTime = DateTime.Parse("2030-01-01 9:00"),
                TemperatureFahrenheit = 82
            },
            new CityWeather
            {
                CityUniqueCode = "NYC",
                CityName = "NewYork",
                DateAndTime = DateTime.Parse("2030-01-01 3:00"),
                TemperatureFahrenheit = 60
            }
        };

        [Route("/")]
        public IActionResult Index()
        {
            return View(weatherList);
        }

        [Route("/weather/{cityCode}")]
        public IActionResult WeatherDetails(string cityCode)
        {
            return View(weatherList.FirstOrDefault(p => p.CityUniqueCode == cityCode));
        }
    }
}
