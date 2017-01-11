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
        string senderEmailAddress = ConfigurationManager.AppSettings["SenderEmailAddress"];
        string smtpHost = ConfigurationManager.AppSettings["SmtpHost"];
        string smtpUsername = ConfigurationManager.AppSettings["SmtpUsername"];
        string smtpPassword = ConfigurationManager.AppSettings["SmtpPassword"];
        int smtpPort = Convert.ToInt16(ConfigurationManager.AppSettings["SmtpPort"]);

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

            #region SmtpConfiguration
            SmtpClient smtpClient = new SmtpClient(smtpHost);
            smtpClient.Port = 123;
            smtpClient.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
            smtpClient.EnableSsl = true;
            #endregion

            smtpClient.Send(mail);
        }
    }
}
