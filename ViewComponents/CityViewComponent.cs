using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using WeatherApp.Models;

namespace WeatherApp.ViewComponents
{
    public class CityViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CityWeather cityWeather)
        {
            var color = "";
            switch (cityWeather.TemperatureFahrenheit)
            {
                case < 44:
                    color = "blue-back";
                    break;
                case >= 44 and < 74:
                    color = "yellow-back";
                    break;
                case > 74:
                    color = "orange-back";
                    break;
            }
            ViewBag.Color = color;
            return View(cityWeather); //invokes view of the view component at Views/Shared/Components/Grid/Sample.cshtml
        }
    }
}
