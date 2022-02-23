namespace SolidSample.OCP.Good
{
    public class Type2Calculator : IPriceCalculator
    {
        public string ClientType => "ClientType2";

        public decimal GetPrice(decimal someBaseValue)
        {
            return Math.Round(someBaseValue * 10 + 3, 2);
        }
    }
}
