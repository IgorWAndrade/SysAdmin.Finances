using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Module.Identity.Core.Entities;
using Module.Identity.Core.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICreateUserUseCase _createUserUseCase;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, 
            ICreateUserUseCase createUserUseCase)
        {
            _logger = logger;
            _createUserUseCase = createUserUseCase;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public void Post(User user)
        {
            _createUserUseCase.CreateNewUser(user);
        }
    }
}
