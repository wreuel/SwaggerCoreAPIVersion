using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPISwagger.Controllers
{
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    [Route("api/v{version:apiVersion}/helloworld")]
    [ApiController]
    public class HelloWorld2Controller : ControllerBase
    {
        [HttpGet, MapToApiVersion("2.0")]
        public string Get() => "Hello world v2!";

        [HttpGet, MapToApiVersion("3.0")]
        public string GetV3() => "Hello world v3!";
    }
}