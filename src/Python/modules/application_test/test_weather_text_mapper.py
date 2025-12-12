import unittest
from unittest.mock import AsyncMock

from modules.domain.user_cases.weather.get.get_weather_command import GetWeatherCommand
from modules.domain.user_cases.weather.get.get_weather_handler import GetWeatherHandler
from modules.domain.user_cases.weather.get.ports.iweather_provider import (
    IWeatherProvider,
)


class TestWeatherTextMapper(unittest.TestCase):
    async def test_handle_should_call_provider_if_called(self):
        provider = AsyncMock(spec=IWeatherProvider)
        handler = GetWeatherHandler(provider)
        command = GetWeatherCommand()

        await handler.handle(command)  # No cancellation token needed in Python

        provider.get_weater.assert_awaited_once()


if __name__ == "__main__":
    unittest.main()
