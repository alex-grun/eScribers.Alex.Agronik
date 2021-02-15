﻿using LoggerCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eScribers.Alex.Agronik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoggerController : ControllerBase
    {
        [HttpGet("Write")]
        public async Task<IActionResult> WriteLog(LoggerContext context, string message)
        {
            var logger = new Logger();
            await logger.Error(context, message);

            return null;
        }
    }
}
