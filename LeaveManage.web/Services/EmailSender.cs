using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManage.web.Services
{
    public class EmailSender : IEmailSender
    {
        private string SmtpServer;

        private int SmtpPort;

        private string EmailAddress;

        public EmailSender(string smtpServer, int smtpPort, string emailAddress)
        {
            this.SmtpServer = smtpServer;
            this.SmtpPort = smtpPort;
            this.EmailAddress = emailAddress;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(EmailAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(EmailAddress));

            using var client = new SmtpClient(SmtpServer, SmtpPort);
            client.Send(message);

            return Task.CompletedTask;
        }
    }
}
