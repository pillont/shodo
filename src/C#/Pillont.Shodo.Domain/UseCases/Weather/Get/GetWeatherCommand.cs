using MediatR;
using Pillont.Shodo.Domain.UseCases.Weather.Models;


namespace Pillont.Shodo.Domain.UseCases.Weather.Get;
public class GetWeatherCommand: IRequest<WeatherModel>
{
}
