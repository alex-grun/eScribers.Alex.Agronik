using LoggerCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eScribers.Alex.Agronik
{
    public interface ILogger
    {
        Task Write(int errorLevel, string message);
        Task Error(LoggerContext loggerContext, string message);
    }
}
