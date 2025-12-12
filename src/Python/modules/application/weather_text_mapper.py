from modules.domain.user_cases.weather.weater_model import WeatherModel


class WeatherTextMapper:
    @staticmethod
    def get_weather_text(weather: WeatherModel) -> str:
        if not weather.is_raining:
            return "WTF ! What is this fireball on the sky ?!"

        return "It's raining, of course we are in britany"
