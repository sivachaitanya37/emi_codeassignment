using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResourceManagement.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Services.Tests
{
    [TestClass()]
    public class PublisherServiceTest
    {
        string sbConnectionString = "";

        [TestMethod()]
        public void PublishTest()
        {
            //Arrange
            bool isSuccess = false;
            PublisherService service = new PublisherService(sbConnectionString);
            string eventName = "TestEvent";
            string eventData = "Event Data";
            string subscriptionName = "TestSubscription";


            var namespaceManager = NamespaceManager.CreateFromConnectionString(sbConnectionString);

            if (!namespaceManager.TopicExists(eventName))
            {
                namespaceManager.CreateTopic(eventName);
            }

            if (!namespaceManager.SubscriptionExists(eventName, subscriptionName))
            {
                namespaceManager.CreateSubscription(eventName, subscriptionName);
            }

            SubscriptionClient sbClient =
                SubscriptionClient.CreateFromConnectionString
                        (sbConnectionString, eventName, subscriptionName);

            sbClient.OnMessage((brokeredMessage) =>
            {
                if (brokeredMessage.GetBody<string>() == eventData)
                {
                    isSuccess = true;
                }
            });

            // Act
            service.Publish(eventName, eventData);

            //Assert
            Assert.IsTrue(isSuccess);
        }
    }
}