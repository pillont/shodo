using Moq;
using Pillont.Shodo.Domain.UseCases.Weather.Get;
using Pillont.Shodo.Domain.UseCases.Weather.Get.Ports;

namespace Pillont.Shodo.Domain.Tests.UseCases.Weather.Get;

public class GetWeatherHandlerTests
{
    [Fact]
    public async Task Handle_ShouldCallProvider_IfCalled()
    {
        var provider = new Mock<IWeatherProvider>();
        var handler = new GetWeatherHandler(provider.Object);

        await handler.Handle(new GetWeatherCommand(), CancellationToken.None);
        provider.Verify(p => p.GetAsync(), Times.Once);
    }
}
