using MediatR;
using Pillont.Shodo.Domain.UseCases.Weather.Get.Ports;
using Pillont.Shodo.Domain.UseCases.Weather.Models;

namespace Pillont.Shodo.Domain.UseCases.Weather.Get;

public class GetWeatherHandler : IRequestHandler<GetWeatherCommand, WeatherModel>
{
    private IWeatherProvider Provider { get; }

    public GetWeatherHandler(
        IWeatherProvider provider)
    {
        Provider = provider;
    }

    public Task<WeatherModel> Handle(GetWeatherCommand request, CancellationToken cancellationToken)
    {
        return Provider.GetAsync();
    }
}
