using System.Windows.Forms;

namespace SendEmailWIthPdfAttchment
{
    class Program
    {
        static void Main(string[] args)
        {
            SendEmail mail = new SendEmail("recipient","ConsoleAppTest","This is a test mail - check attachments",new Attachments().MailAttachment());
            MessageBox.Show("Mail was sent");
        }
    }
}
