using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendEmailWIthPdfAttchment
{
    class MailModel
    {
        public string Address { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public AttachmentCollection Attachments { get; }
    }
}
