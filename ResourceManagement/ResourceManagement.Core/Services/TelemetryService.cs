using ResourceManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResourceManagement.Core.Models;

namespace ResourceManagement.Core.Services
{
    public class TelemetryService : ITelemetryService
    {
        public void LogMetric(Metric metric, int count = 1)
        {
            throw new NotImplementedException();
        }
    }
}
