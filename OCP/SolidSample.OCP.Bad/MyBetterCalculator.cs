namespace SolidSample.OCP.Bad
{
    public class MyBetterCalculator
    {
        public decimal GetCalculatedPrice(string clientType, decimal someBaseValue)
        {
            IPriceCalculator calculator = null!;

            if (clientType.Equals("ClientType1", StringComparison.OrdinalIgnoreCase))
            {
                calculator = new Type1Calculator();
            }
            else if (clientType.Equals("ClientType2", StringComparison.OrdinalIgnoreCase))
            {
                calculator = new Type2Calculator();
            }
            else if (clientType.Equals("ClientType3", StringComparison.OrdinalIgnoreCase))
            {
                calculator = new Type3Calculator();
            }

            if (calculator is not null)
            {
                return calculator.GetPrice(someBaseValue);
            }

            throw new NotSupportedException();
        }
    }

    public interface IPriceCalculator
    {
        decimal GetPrice(decimal someBaseValue);
    }

    public class Type1Calculator : IPriceCalculator
    {
        public decimal GetPrice(decimal someBaseValue)
        {
            return Math.Round(someBaseValue * 10, 2);
        }
    }

    public class Type2Calculator : IPriceCalculator
    {
        public decimal GetPrice(decimal someBaseValue)
        {
            return Math.Round(someBaseValue * 10 + 3, 2);
        }
    }

    public class Type3Calculator : IPriceCalculator
    {
        public decimal GetPrice(decimal someBaseValue)
        {
            return Math.Round(someBaseValue + 2, 2);
        }
    }
}
