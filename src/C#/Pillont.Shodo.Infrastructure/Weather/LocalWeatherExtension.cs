using Microsoft.Extensions.DependencyInjection;
using Pillont.Shodo.Domain.UseCases.Weather.Get.Ports;
using Pillont.Shodo.Infrastructure.Weather;

namespace Pillont.Shodo.Infrastructure;

public static class LocalWeatherExtension
{

    public static IServiceCollection AddLocalWeatherInfrastructure(this IServiceCollection collection)
    {
        return collection.AddSingleton<IWeatherProvider, LocalWeatherProvider>();
    }
}
