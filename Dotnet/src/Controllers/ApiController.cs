using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<Controllers.ApiController> _logger;

        public ApiController(ILogger<Controllers.ApiController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult Get() =>
            Ok(new
            {
                Os = Environment.OSVersion,
                MachineName = Environment.MachineName,
                HostName = Dns.GetHostName()
            });
    }
}
