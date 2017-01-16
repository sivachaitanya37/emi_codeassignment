using ResourceManagement.Core.Interfaces;
using ResourceManagement.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Factories
{
    public class ServiceFactory
    {
        public static ITelemetryService TelemetryService { get; set; }
        public static IEmailService EmailService { get; set; }
        public static IPublisherService PublisherService { get; set; }

        static ServiceFactory()
        {
            //TelemetryService = new TelemetryService();
            //EmailService = new EmailService();
            //PublisherService = new PublisherService();
        }
    }
}
