namespace SolidSample.OCP.Good
{
    public class Type1Calculator : IPriceCalculator
    {
        public string ClientType => "ClientType1";

        public decimal GetPrice(decimal someBaseValue)
        {
            return Math.Round(someBaseValue * 10, 2);
        }
    }
}
