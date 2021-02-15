using System;

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
