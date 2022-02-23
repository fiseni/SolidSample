using System.Net.Mail;

namespace SolidSample.DIP.Good
{
    public class OrderService
    {
        private readonly IEmailSender _emailSender;

        public OrderService(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void CompleteOrder()
        {
            Console.WriteLine("Order saved and completed!");

            _emailSender.Send(new MailMessage());
        }
    }
}
