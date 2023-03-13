using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DependencyInjection.NumGenerator;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly INumGenerator2 numGenerator2;

        public WeatherForecastController(INumGenerator2 numGenerator2)
        {
            this.numGenerator2 = numGenerator2;
        }

        [HttpGet]
        public string Get()
        {
            int random1 = numGenerator2.RandomValue;
            int random2 = numGenerator2.GetNumGeneratorRandomNumber();
            return $"numGenerator2.RandomValue: {random1} , numGenerator.RandomValue:{random2}";

        }
    }
}
