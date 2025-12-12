using Microsoft.Extensions.DependencyInjection;
using Pillont.Shodo.Infrastructure;

namespace Pillont.Shodo.Application.Injector;

public static class ShodoInjector
{
    public static ServiceProvider GetServiceProvider()
    {
        return new ServiceCollection()
            .AddShodo()
            .BuildServiceProvider();
    }

    public static IServiceCollection AddShodo(this IServiceCollection services)
    {
        return services
            .AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(ShodoInjector)))
            .AddGetWeather()
            .AddLocalWeatherInfrastructure();
    }
}
