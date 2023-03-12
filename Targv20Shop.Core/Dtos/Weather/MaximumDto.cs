﻿using Newtonsoft.Json;

namespace Targv20Shop.Core.Dtos.Weather
{
    public class MaximumDto
    {
        [JsonProperty("Value")]
        public double Value { get; set; }

        [JsonProperty("Unit")]
        public string Unit { get; set; }

        [JsonProperty("UnitType")]
        public int UnitType { get; set; }
    }
}