using Microsoft.AspNetCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eScribers.MicroService.Prividers
{
    public interface ILoggerProvider
    {
        void Error();
    }
}
