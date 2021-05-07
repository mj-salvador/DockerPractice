using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDocker.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DockerController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello Docker";
        }
    }
}
