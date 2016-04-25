using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SendEmailWIthPdfAttchment
{
    class SendEmail
    {
        public SendEmail(string recipient, string subject, string body, Attachment attachment)
        {
            string sender = "";
            SmtpClient smtpClient = new SmtpClient();
            var mailMessage = new MailMessage(sender, recipient)
            {
                Subject = subject,
                BodyEncoding = System.Text.Encoding.UTF8,
                Body = Regex.Unescape(body)
            };

            mailMessage.From = new MailAddress(sender);
            mailMessage.Subject = subject;
            mailMessage.IsBodyHtml = false;
            mailMessage.Body = body;
            mailMessage.To.Add(recipient);

            // setup up the host, increase the timeout to 5 minutes
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(sender, "password"),
                EnableSsl = true
            };

            if (attachment.Name != null)
                mailMessage.Attachments.Add(attachment);

            client.Send(mailMessage);
        }
    }
}
