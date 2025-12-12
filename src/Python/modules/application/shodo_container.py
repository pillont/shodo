from di import Container
from diator.events import EventMap, EventEmitter
from diator.mediator import Mediator
from diator.requests import RequestMap

from diator.container.di import DIContainer
from modules.domain.user_cases.weather.get.get_weather_command import GetWeatherCommand
from modules.domain.user_cases.weather.get.get_weather_extension import add_get_weather
from modules.domain.user_cases.weather.get.get_weather_handler import GetWeatherHandler
from modules.infrastructure.local_weather_provider_extension import (
    add_weather_provider_as_local,
)


def __setup_container():
    external_container = Container()

    add_get_weather(external_container)
    add_weather_provider_as_local(external_container)

    return external_container


def __setup_di() -> DIContainer:
    container = DIContainer()

    external_container = __setup_container()
    container.attach_external_container(external_container)

    return container


def get_mediator():
    container = __setup_di()

    request_map = RequestMap()
    request_map.bind(GetWeatherCommand, GetWeatherHandler)

    event_emitter = EventEmitter(
        event_map=EventMap(), container=container, message_broker=None
    )

    mediator = Mediator(
        request_map=request_map,
        event_emitter=event_emitter,
        container=container,
    )

    return mediator
