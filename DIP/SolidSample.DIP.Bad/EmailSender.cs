using System.Net.Mail;

namespace SolidSample.DIP.Bad
{
    public class EmailSender
    {
        public bool Send(MailMessage message)
        {
            // Sending the mail through a SMTP client or any other service we might have.

            Console.WriteLine("Email sent to the user!");
            return true;
        }
    }
}
