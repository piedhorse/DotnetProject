﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static DependencyInjection.NumGenerator;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly INumGenerator numGenerator;

        public TestController(INumGenerator numGenerator)
        {
            this.numGenerator = numGenerator;
        }

        [HttpGet]
        public string Get()
        {
            
            return numGenerator.RandomValue.ToString();
        }
    }
}
