﻿using Nancy.Json;
using Targv20Shop.Core.Dtos;
using Targv20Shop.Core.Dtos.Weather;
using Targv20Shop.Core.ServiceInterface;
using System.Net;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Targv20Shop.ApplicationServices.Services
{
    public class WeatherForecastServices : IWeatherForecastServices
    {
        public async Task<OpenWeatherResultDto> WeatherDetail(OpenWeatherResultDto dto)
        {
            string apikey = "f85b453b47a30414165b84c61fc7ed15"; //APi key
            var url = $"http://api.openweathermap.org/data/2.5/weather?q={dto.name}&limit=5&units=metric&appid={apikey}";

            var url1 = $"http://api.openweathermap.org/data/2.5/weather?id={dto.name}&units=metri&appid={apikey}";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                OpenWeatherRoot weatherInfo = (new JavaScriptSerializer()).Deserialize<OpenWeatherRoot>(json);

                dto.name = weatherInfo.name;
                dto.main = weatherInfo.weather[0].main;
                dto.description = weatherInfo.weather[0].description;


                dto.temp = weatherInfo.main.temp;
                dto.feels_like = weatherInfo.main.feels_like;
                dto.temp_min = weatherInfo.main.temp_min;
                dto.temp_max = weatherInfo.main.temp_max;
                dto.pressure = weatherInfo.main.pressure;
                dto.humidity = weatherInfo.main.humidity;
                dto.visibility = weatherInfo.visibility;

                dto.speed = weatherInfo.wind.speed;
                //dto.deg = weatherInfo.wind.deg;

                //dto.all = weatherInfo.clouds.all;

                dto.dt = weatherInfo.dt;

                //dto.type = weatherInfo.sys.type;
                //dto.id = weatherInfo.sys.id;
                //dto.message = weatherInfo.sys.message;
                //dto.country = weatherInfo.sys.country;
                //dto.sunrise = weatherInfo.sys.sunrise;
                //dto.sunset = weatherInfo.sys.sunset;
                dto.timezone = weatherInfo.timezone;

                var jsonString = new JavaScriptSerializer().Serialize(dto);

            }
            return dto;
        }

    }
}
