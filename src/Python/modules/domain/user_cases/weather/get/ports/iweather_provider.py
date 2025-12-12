from abc import ABC, abstractmethod

from modules.domain.user_cases.weather.weater_model import WeatherModel


class IWeatherProvider(ABC):
    @abstractmethod
    async def get_weater(self) -> WeatherModel:
        raise NotImplementedError()
