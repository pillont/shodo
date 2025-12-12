using Pillont.Shodo.Domain.UseCases.Weather.Models;

namespace Pillont.Shodo.Application.Console.Tests;
public class WeatherTextMapperTest
{
    [Fact]
    public void GetWeatherText_ShouldReturnValidValue_IfIsRaining_Test()
    {
        var result = WeatherTextMapper.GetWeatherText(new WeatherModel() { IsRaining = true });

        Assert.Equal(
            "It's raining, of course we are in britany",
            result
        );
    }

    [Fact]
    public void GetWeatherText_ShouldReturnWTFValue_IfIsNotRaining_Test()
    {
        var result = WeatherTextMapper.GetWeatherText(new WeatherModel() { IsRaining = false});

        Assert.Equal(
            "WTF ! What is this fireball on the sky ?!",
            result
        );
    }
}
