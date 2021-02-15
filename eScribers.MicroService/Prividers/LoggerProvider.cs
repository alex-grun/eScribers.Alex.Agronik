using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eScribers.MicroService.Prividers
{
    // Logz.io Provider
    public class LoggerProvider : ILoggerProvider
    {
        public void Error()
        {
            // calling to Logz.io
            throw new NotImplementedException();
        }
    }
}
