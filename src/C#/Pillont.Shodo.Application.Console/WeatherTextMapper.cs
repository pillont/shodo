using Pillont.Shodo.Domain.UseCases.Weather.Models;

namespace Pillont.Shodo.Application.Console;

public static class WeatherTextMapper
{
    public static string GetWeatherText(WeatherModel weather)
    {
        if (!weather.IsRaining)
            return "WTF ! What is this fireball on the sky ?!";

        return "It's raining, of course we are in britany";
    }
}
