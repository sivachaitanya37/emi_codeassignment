using ResourceManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus;
using System.Configuration;
using Microsoft.ServiceBus.Messaging;

namespace ResourceManagement.Core.Services
{
    public class PublisherService : IPublisherService
    {
        string sbConnectionString = string.Empty;

        public PublisherService(string sbConnectionString)
        {
            this.sbConnectionString = sbConnectionString;
        }

        public void Publish(string eventName, string eventData)
        {
            // Configure Topic Settings.
            TopicDescription td = new TopicDescription(eventName);
            td.MaxSizeInMegabytes = 5120;
            td.DefaultMessageTimeToLive = new TimeSpan(0, 1, 0);


            #region Creating Topic
            var namespaceManager = NamespaceManager.CreateFromConnectionString(sbConnectionString);

            if (!namespaceManager.TopicExists(eventName))
            {
                namespaceManager.CreateTopic(eventName);
            }
            #endregion

            TopicClient Client =
    TopicClient.CreateFromConnectionString(sbConnectionString, eventName);

            Client.Send(new BrokeredMessage(eventData));
        }
    }
}
