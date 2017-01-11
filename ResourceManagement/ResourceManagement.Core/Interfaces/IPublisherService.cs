using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Interfaces
{
    public interface IPublisherService
    {
        void Publish(string eventName, string eventData);
    }
}
