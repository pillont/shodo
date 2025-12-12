import unittest
from modules.infrastructure.local_weather_provider import LocalWeatherProvider


class TestLocalWeatherProvider(unittest.TestCase):
    async def test_get_async_should_return_raining_weather_because_we_are_in_brittany(
        self,
    ):
        provider = LocalWeatherProvider()
        result = await provider.get_weater()
        self.assertTrue(result.is_raining)


if __name__ == "__main__":
    unittest.main()
