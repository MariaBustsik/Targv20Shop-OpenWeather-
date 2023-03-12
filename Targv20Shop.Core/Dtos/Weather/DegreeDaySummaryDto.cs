using Newtonsoft.Json;

namespace Targv20Shop.Core.Dtos.Weather
{
    public class DegreeDaySummaryDto
    {
        public HeatingDto Heating { get; set; }

        public Cooling Cooling { get; set; }
    }
}