using WeatherApp.Models;

namespace WeatherApp.ServiceContracts
{
    public interface ICityWeatherService
    {
        public IEnumerable<CityWeather> CitiesWeather { get; set; }
    }
}
