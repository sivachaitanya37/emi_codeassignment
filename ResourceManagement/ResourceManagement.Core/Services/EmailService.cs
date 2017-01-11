using ResourceManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Services
{
    public class EmailService : IEmailService
    {
        public void Send(List<string> toList, List<string> ccList, string body, string subject)
        {
            throw new NotImplementedException();
        }
    }
}
