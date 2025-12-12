using Pillont.Shodo.Domain.UseCases.Weather.Get.Ports;
using Pillont.Shodo.Domain.UseCases.Weather.Models;

namespace Pillont.Shodo.Infrastructure.Weather;

public class LocalWeatherProvider : IWeatherProvider
{
    private WeatherModel CurrentWeather { get; set; } = new WeatherModel() 
    { 
        IsRaining = true 
    };

    public Task<WeatherModel> GetAsync()
    {
        return Task.FromResult(CurrentWeather );
    }
}
