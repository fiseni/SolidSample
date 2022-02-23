using System.Net.Mail;

namespace SolidSample.DIP.Bad
{
    public class OrderService
    {
        public void CompleteOrder()
        {
            Console.WriteLine("Order saved and completed!");

            var emailSender = new EmailSender();
            emailSender.Send(new MailMessage());
        }
    }
}
