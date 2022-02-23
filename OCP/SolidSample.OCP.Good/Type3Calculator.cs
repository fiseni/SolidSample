namespace SolidSample.OCP.Good
{
    public class Type3Calculator : IPriceCalculator
    {
        public string ClientType => "ClientType3";

        public decimal GetPrice(decimal someBaseValue)
        {
            return Math.Round(someBaseValue + 2, 2);
        }
    }
}
