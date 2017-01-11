using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Interfaces
{
    public interface ILoggingService
    {
        void LogError(Exception ex);
        void LogError(string errorMessage);
        void LogWarning(string warningMessage);
        void LogInfo(string infoMessage);
        void LogDebug(string debugMessage);
    }
}
