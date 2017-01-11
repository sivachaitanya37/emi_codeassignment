using ResourceManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResourceManagement.Core.Models;
using Microsoft.ApplicationInsights;

namespace ResourceManagement.Core.Services
{
    public class TelemetryService : ITelemetryService
    {
        TelemetryClient client = new TelemetryClient();
        public void LogMetric(Metric metric, int count = 1)
        {
            client.TrackMetric(metric.Title, count);
        }
        public void LogExccpetion(Exception ex)
        {
            client.TrackException(ex);
        }
        public void LogTrace(string message)
        {
            client.TrackTrace(message);
        }
    }
}
