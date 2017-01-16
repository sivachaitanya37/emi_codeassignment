using ResourceManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;

namespace ResourceManagement.Core.Services
{
    public class EmailService : IEmailService
    {
        string senderEmailAddress = string.Empty;
        string smtpHost = string.Empty;
        string smtpUsername = string.Empty;
        string smtpPassword = string.Empty;
        int smtpPort;
        public EmailService(string senderEmailAddress, string smtpHost,
            string smtpUsername, string smtpPassword, int smtpPort)
        {
            this.senderEmailAddress = senderEmailAddress;
            this.smtpHost = smtpHost;
            this.smtpUsername = smtpUsername;
            this.smtpPassword = smtpPassword;
            this.smtpPort = smtpPort;
        }
        public void Send(List<string> toList, List<string> ccList, string body, string subject)
        {
            #region BuildingMail
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmailAddress);
            mail.Subject = subject;
            mail.Body = body;
            toList.ForEach(item => mail.To.Add(item));
            ccList.ForEach(item => mail.CC.Add(item));
            #endregion

            using (SmtpClient smtpClient = new SmtpClient(smtpHost))
            {
                smtpClient.Port = smtpPort;
                smtpClient.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);
            }
        }
    }
}
