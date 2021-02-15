using LoggerCore;
using System.Threading.Tasks;

namespace eScribers.Alex.Agronik
{
    public interface ILogger
    {
        Task Write(int errorLevel, string message);
        Task Error(LoggerContext loggerContext, string message);
    }
}
