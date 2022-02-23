namespace SolidSample.OCP.Good
{
    public interface IPriceCalculator
    {
        string ClientType { get; }
        decimal GetPrice(decimal someBaseValue);
    }
}
