namespace SolidSample.OCP.Good
{
    public interface ICalculator
    {
        decimal GetCalculatedPrice(string clientType, decimal someBaseValue);
    }
}