
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebSecurity.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("test@gmail.com", "28AxtJm2oowew!"),
                EnableSsl = true
            };

            MailAddress from = new MailAddress("anis16-10@hotmail.com", "Admin ");
            MailAddress to = new MailAddress(email);

            MailMessage msg = new MailMessage(from, to);
            msg.Subject = subject;
            msg.Body = message;

            smtpClient.Send(msg);

            return Task.CompletedTask;
        }
    }
}
