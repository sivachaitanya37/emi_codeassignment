using ResourceManagement.Core.Interfaces;
using ResourceManagement.Core.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Services
{
    public class LoggingService : ILoggingService
    {
        string loggerCompletePath = ConfigurationManager.AppSettings["LoggerPathWithExtension"];

        public void LogDebug(string debugMessage)
        {
            Log("Debug", debugMessage);
        }

        public void LogError(string errorMessage)
        {
            Log("Error", errorMessage);
        }

        public void LogError(Exception ex)
        {
            Log("Error", ex.Message);
        }

        public void LogInfo(string infoMessage)
        {
            Log("Info", infoMessage);
        }

        public void LogWarning(string warningMessage)
        {
            Log("Warning", warningMessage);
        }

        private void Log(string type, string message)
        {
            if (!File.Exists(loggerCompletePath))
            {
                File.Create(loggerCompletePath);
            }
            using (StreamWriter writer = new StreamWriter(loggerCompletePath, true))
            {
                writer.WriteLine(DateTime.Now.ToString() + " ===> " + type + " ===> " + message);
            }
        }
    }
}
