
using Pillont.Shodo.Infrastructure.Weather;

namespace Pillont.Shodo.Infrastructure.Tests.Weather;

public class LocalWeatherProviderTest
{
    public LocalWeatherProviderTest()
    {
        Provider = new LocalWeatherProvider();
    }

    private  LocalWeatherProvider Provider { get; }

    [Fact]
    public async Task GetAsync_ShouldReturnRainingWeather_ByDefaultBecauseWeAreInBrittany_TestAsync()
    {
        var result = await Provider.GetAsync();
        Assert.True(result.IsRaining);
    }
}
