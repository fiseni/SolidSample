namespace SolidSample.SRP.Good.Exceptions
{
    public class InvalidEmailException : Exception
    {
        private const string _message = "The email is not valid!";

        public InvalidEmailException() : base(_message)
        {
        }

        public InvalidEmailException(Exception innerException) : base(_message, innerException)
        {
        }
    }
}
