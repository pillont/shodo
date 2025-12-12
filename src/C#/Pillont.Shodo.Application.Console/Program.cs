using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Pillont.Shodo.Application.Console;
using Pillont.Shodo.Application.Injector;
using Pillont.Shodo.Domain.UseCases.Weather.Get;
using Pillont.Shodo.Domain.UseCases.Weather.Models;

using var provider = ShodoInjector.GetServiceProvider();

Console.WriteLine("wait, I will check the weather...");

var text = await GetWeatherText();

Console.WriteLine(text);

async Task<string> GetWeatherText()
{
    var weather = await GetWeather();

    return WeatherTextMapper.GetWeatherText(weather);
}

async Task<WeatherModel> GetWeather()
{
    var mediator = provider.GetRequiredService<IMediator>();

    return await mediator.Send(new GetWeatherCommand());
}
