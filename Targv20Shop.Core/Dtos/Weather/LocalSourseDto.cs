﻿using Newtonsoft.Json;

namespace Targv20Shop.Core.Dtos.Weather
{
    public class LocalSourseDto
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("WeatherCode")]
        public string WeatherCode { get; set; }
    }
}