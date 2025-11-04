using System;
using Microsoft.AspNetCore.Mvc;

namespace hello_world_dotnet.Controllers
{
    [ApiController]
    [Route("")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public HelloWorld Get()
        {
            return new()
            {
                Message = "Automate all the things! bumping to version to 2.0.0  ",
                Timestamp = DateTime.Now
            };
        }
    }
}