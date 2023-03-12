using Targv20Shop.Dtos.Weather;
using System.Collections.Generic;

namespace Targv20Shop.Core.Dtos.Weather
{
    public class WeatherRootDto
    {
        public HeadlineDto Headline { get; set; }
        public List<DailyForecastDto> DailyForecasts { get; set; }
    }
}
