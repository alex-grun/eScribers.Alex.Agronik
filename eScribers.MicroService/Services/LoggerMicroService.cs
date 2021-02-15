using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eScribers.MicroService.Prividers;
using LoggerCore;

namespace eScribers.MicroService.Services
{
    public class LoggerMicroService
    {
        public void Write(LoggerInternal loggerInternal, int errorLevel, string message)
        {
            switch (errorLevel)
            {
                case (int)ErrorLevel.Debug:
                case (int)ErrorLevel.Info:
                case (int)ErrorLevel.Warning:
                case (int)ErrorLevel.Error:
                    // call Log4Net / Logz.io / DataDog / MySQL
                    new LoggerProvider().Error(); // (loggerInternal, loggerContext, errorLevel, message);
                    break;
                case (int)ErrorLevel.Fatal:
                default:
                    Console.WriteLine("Unknown errorLevel.");
                    break;
            }
        }
    }
}
