﻿using Newtonsoft.Json;

namespace Targv20Shop.Core.Dtos.Weather
{
    public class DirectionDto
    {

        [JsonProperty("Degrees")]
        public double Degrees { get; set; }

        [JsonProperty("Localized")]
        public string Localized { get; set; }

        [JsonProperty("English")]
        public string English { get; set; }

    }
}