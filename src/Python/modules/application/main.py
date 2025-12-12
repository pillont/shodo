import asyncio
from typing import cast


from modules.application.shodo_container import get_mediator
from modules.application.weather_text_mapper import WeatherTextMapper
from modules.domain.user_cases.weather.get.get_weather_command import GetWeatherCommand
from modules.domain.user_cases.weather.weater_model import WeatherModel


async def __get_weather() -> WeatherModel:
    mediator = get_mediator()

    result = await mediator.send(GetWeatherCommand())
    return cast(WeatherModel, result)


async def __get_weather_text() -> str:
    weather = await __get_weather()
    return WeatherTextMapper.get_weather_text(weather)


if __name__ == "__main__":

    print("wait, I will check the weather...")

    text = asyncio.run(__get_weather_text())

    print(text)
