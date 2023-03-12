using Microsoft.AspNetCore.Mvc;
using Targv20Shop.Core.Dtos.Weather;
using Targv20Shop.Core.ServiceInterface;
using Targv20Shop.Models.Weather;

namespace Targv20Shop.Controllers
{
    public class OpenWeatherController : Controller
    {
        private readonly IWeatherForecastServices _weatherForecastServices;

        public OpenWeatherController
            (
                IWeatherForecastServices weatherForecastServices
            )
        {
            _weatherForecastServices = weatherForecastServices;
        }

        [HttpGet]
        public IActionResult OpenSearchCity()
        {
            OpenSearchCity sc = new OpenSearchCity();

            return View(sc);
        }

        [HttpPost]
        public IActionResult OpenSearchCity(OpenSearchCity model)
        {
            if (ModelState.IsValid)

            {
                return RedirectToAction("City", "OpenWeather", new { city = model.name });
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult City(string city)
        {
            OpenWeatherResultDto dto = new OpenWeatherResultDto();

            dto.name = city;

            var weatherResponse = _weatherForecastServices.WeatherDetail(dto);
            OpenCityViewModel model = new OpenCityViewModel();


            model.name = weatherResponse.Result.name;
            model.temp = weatherResponse.Result.temp;
            model.feels_like = weatherResponse.Result.feels_like;
            model.humidity = weatherResponse.Result.humidity;
            model.pressure = weatherResponse.Result.pressure;
            model.speed = weatherResponse.Result.speed;
            model.main = weatherResponse.Result.main;

            return View(model);

        }
    }

}