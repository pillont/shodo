from di import Container, bind_by_type
from di.dependent import Dependent

from modules.domain.user_cases.weather.get.get_weather_handler import GetWeatherHandler


def add_get_weather(external_container: Container):
    external_container.bind(
        bind_by_type(
            Dependent(GetWeatherHandler, scope="request"),
            GetWeatherHandler,
        )
    )
