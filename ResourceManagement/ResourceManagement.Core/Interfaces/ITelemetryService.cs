using ResourceManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Interfaces
{
    public interface ITelemetryService
    {
        void LogMetric(Metric metric, int count = 1);
    }
}
