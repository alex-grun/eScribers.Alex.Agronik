using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading.Tasks;
using LoggerCore;
using Microsoft.Extensions.Options;
using eScribers.MicroService.Prividers;
using eScribers.MicroService.Services;

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
            var service = new LoggerMicroService();
            service.Write(new LoggerInternal(), 0, "");

            return null;
        }
    }
}
