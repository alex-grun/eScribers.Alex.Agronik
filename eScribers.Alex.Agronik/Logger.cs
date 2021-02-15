using LoggerCore;
using System;
using System.Threading.Tasks;

namespace eScribers.Alex.Agronik
{
    public class Logger : ILogger
    {
        private LocalLoggerConfig _loggerConfig;
        private LoggerContext _loggerContext;

        public Logger()
        {
            this._loggerConfig = GetLoggerConfig();
        }

        private LoggerInternal GetLocalData() // InternalGeneral
        {
            //var feature = HttpContext.Features.Get<IHttpConnectionFeature>();

            return new LoggerInternal
            { 
                Ip = "0.0.0.0", //feature?.LocalIpAddress?.ToString(),
                Datetime = DateTime.Now,
                Environment = Environment.GetEnvironmentVariable("Environment"),
                OS = Environment.OSVersion.Platform,
                CallingStack = false,
                CallingSourceCode = false         
            };
        }

        public async Task Write(int errorLevel, string message)
        {
            var loggerInternal = GetLocalData();

            Console.Write(message);

            if (_loggerConfig.ShallSentToLoggerMicrservice(_loggerContext.User, errorLevel))
            {
                LogicalSendToMicroserviceEndpoint(loggerInternal, errorLevel, message);
            }
        }

        public async Task Error(LoggerContext loggerContext, string message)
        {
            await Write(loggerContext, ErrorLevel.Error, message);
        }

        private async Task Write(LoggerContext loggerContext, ErrorLevel errorLevel, string message)
        {
            this._loggerContext = loggerContext;
            await Write((int)errorLevel, message);
        }

        private LocalLoggerConfig GetLoggerConfig()
        {
            return new LocalLoggerConfig();
        }

        private void LogicalSendToMicroserviceEndpoint(LoggerInternal loggerInternal, int errorLevel, string message)
        {
            // call microservice endpoint LoggerService/WriteLog
        }
    }

    public class LocalLoggerConfig
    {
        public LocalLoggerConfig()
        {
            // call microservice endpoint LoggerService/LoggerConfig
        }

        public bool ShallSentToLoggerMicrservice(string module, int level)
        {
            return true;
        }
    }
}
