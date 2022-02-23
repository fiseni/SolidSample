using System.Net.Mail;

namespace SolidSample.DIP.Good
{
    public interface IEmailSender
    {
        bool Send(MailMessage message);
    }
}