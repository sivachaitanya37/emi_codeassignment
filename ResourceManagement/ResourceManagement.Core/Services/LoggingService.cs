using ResourceManagement.Core.Interfaces;
using ResourceManagement.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Services
{
    public class LoggingService : ILoggingService
    {
        public void LogDebug(string debugMessage)
        {
            throw new NotImplementedException();
        }

        public void LogError(string errorMessage)
        {
            throw new NotImplementedException();
        }

        public void LogError(Exception ex)
        {
            throw new NotImplementedException();
        }

        public void LogInfo(string infoMessage)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string warningMessage)
        {
            throw new NotImplementedException();
        }
    }
}
