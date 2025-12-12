from modules.domain.user_cases.weather.get.ports.iweather_provider import (
    IWeatherProvider,
)
from modules.domain.user_cases.weather.weater_model import WeatherModel


class LocalWeatherProvider(IWeatherProvider):
    async def get_weater(self) -> "WeatherModel":
        return WeatherModel(is_raining=True)
