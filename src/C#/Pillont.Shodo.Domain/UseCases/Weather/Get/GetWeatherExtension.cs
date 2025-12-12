using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Pillont.Shodo.Domain.UseCases.Weather.Get;
using Pillont.Shodo.Domain.UseCases.Weather.Models;

namespace Pillont.Shodo.Infrastructure;

public static class GetWeatherExtension
{

    public static IServiceCollection AddGetWeather(this IServiceCollection collection)
    {
        return collection.AddSingleton<IRequestHandler<GetWeatherCommand, WeatherModel>, GetWeatherHandler>();
    }
}
