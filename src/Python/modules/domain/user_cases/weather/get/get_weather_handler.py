from typing import Final, override

from diator.requests import RequestHandler

from modules.domain.user_cases.weather.get.get_weather_command import GetWeatherCommand
from modules.domain.user_cases.weather.get.ports.iweather_provider import (
    IWeatherProvider,
)
from modules.domain.user_cases.weather.weater_model import WeatherModel


class GetWeatherHandler(RequestHandler[GetWeatherCommand, WeatherModel]):
    def __init__(self, provider: IWeatherProvider) -> None:
        self.provider: Final = provider

    @override
    async def handle(self, request: GetWeatherCommand) -> WeatherModel:
        return await self.provider.get_weater()
