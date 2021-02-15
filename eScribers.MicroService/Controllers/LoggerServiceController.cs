using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggerCore;
using Microsoft.Extensions.Options;
using eScribers.MicroService.Prividers;

namespace eScribers.MicroService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoggerServiceController : ControllerBase
    {
        private readonly IOptions<LoggerConfig> _configuration;

        public LoggerServiceController(IOptions<LoggerConfig> configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("LoggerConfig")]
        public async Task<string> GetLoggerConfig()
        {
            var result = JsonSerializer.Serialize(_configuration.Value);
            return result;
        }

        [HttpPost("WriteLog")]
        public async Task<IActionResult> WriteLog()
        {
            var provider = new LoggerProvider();
            provider.Error();

            return null;
        }
    }
}
