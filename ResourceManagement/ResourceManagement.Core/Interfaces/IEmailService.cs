using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Interfaces
{
    public interface IEmailService
    {
        void Send(List<string> toList, List<string> ccList, string body, string subject);
    }
}
