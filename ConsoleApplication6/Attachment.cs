using SelectPdf;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;


namespace SendEmailWIthPdfAttchment
{
    class Attachments
    {
        public Attachments() { }

        public Attachment MailAttachment()
        {
            var stream = new MemoryStream();

            HtmlToPdf converter = new HtmlToPdf();
            PdfDocument doc = new PdfDocument();

            var html = "TEST";
            var result = converter.ConvertHtmlString(html);
            result.Save(stream);
            stream.Position = 0;
            result.Close();
            return new Attachment(stream, "test.pdf", MediaTypeNames.Application.Pdf);
            
        }
    }
}
