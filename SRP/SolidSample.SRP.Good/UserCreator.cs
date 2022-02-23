using Ardalis.GuardClauses;
using SolidSample.SRP.Good.Exceptions;
using System.Net.Mail;

namespace SolidSample.SRP.Good
{
    public class UserCreator
    {
        private readonly EmailSender _emailSender;

        public UserCreator(EmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void Register(string email, string password)
        {
            // Validation is done through a separate construct
            Guard.Against.InvalidEmail(email);

            // Creates the user
            // Persists the user
            Console.WriteLine("User created and saved!");

            _emailSender.Send(new MailMessage());
            Console.WriteLine("Sent mail to the user!");
        }
    }
}
