using Pillont.Shodo.Domain.UseCases.Weather.Models;

namespace Pillont.Shodo.Application.Console;
public static class WeatherTextMapper
{
    public static string GetWeatherText(WeatherModel weather)
    {
        return weather.IsRaining
            ? "It's raining, of course we are in britany"
            : "WTF ! What is this fireball on the sky ?!";
    }
}
