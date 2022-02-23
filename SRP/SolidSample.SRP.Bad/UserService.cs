using System.Net.Mail;

namespace SolidSample.SRP.Bad
{
    public class UserService
    {
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
            {
                throw new Exception("The email is not valid!");
            }

            // Creates the user
            // Persists the user
            Console.WriteLine("User created and saved!");
            
            // Sends mail
            Console.WriteLine("Sent mail to the user!");
        }

        public bool ValidateEmail(string email)
        {
            // Sample validation
            return email.Contains("@");
        }

        public bool SendMail(MailMessage message)
        {
            // Sending the mail through a SMTP client or any other service we might have.
            Console.WriteLine("Mail sent!");
            
            return true;
        }
    }
}
