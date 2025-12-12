from dataclasses import dataclass
from diator.response import Response


@dataclass(frozen=True)
class WeatherModel(Response):
    is_raining: bool
