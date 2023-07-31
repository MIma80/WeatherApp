using WeatherApp.Models;
using WeatherApp.ServiceContracts;

namespace WeatherApp.Services
{
    public class CityWeatherService : ICityWeatherService
    {
        public IEnumerable<CityWeather> CitiesWeather { get; set; } =
            new List<CityWeather>
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
    }
}
