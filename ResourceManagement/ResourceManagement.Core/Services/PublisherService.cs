using ResourceManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Services
{
    public class PublisherService : IPublisherService
    {
        // Hardcode service bus connection...
        string sbConnectionString = "";

        public void Publish(string eventName, string eventData)
        {
            // eventName -> Topic
            // sb message body -> eventData
        }
    }
}
