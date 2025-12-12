from di import Container, bind_by_type
from di.dependent import Dependent
from modules.domain.user_cases.weather.get.ports.iweather_provider import (
    IWeatherProvider,
)
from modules.infrastructure.local_weather_provider import LocalWeatherProvider


def add_weather_provider_as_local(external_container: Container):
    external_container.bind(
        bind_by_type(
            Dependent(LocalWeatherProvider, scope="request"),
            IWeatherProvider,
        )
    )
