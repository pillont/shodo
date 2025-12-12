using Pillont.Shodo.Domain.UseCases.Weather.Models;

namespace Pillont.Shodo.Domain.UseCases.Weather.Get.Ports;

public interface IWeatherProvider
{
    Task<WeatherModel> GetAsync();
}
