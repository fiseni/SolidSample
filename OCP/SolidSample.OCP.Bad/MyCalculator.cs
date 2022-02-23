namespace SolidSample.OCP.Bad
{
    public class MyCalculator
    {
        public decimal GetCalculatedPrice(string clientType, decimal someBaseValue)
        {
            if (clientType.Equals("ClientType1", StringComparison.OrdinalIgnoreCase))
            {
                return Math.Round(someBaseValue * 10, 2);
            }
            else if (clientType.Equals("ClientType2", StringComparison.OrdinalIgnoreCase))
            {
                return Math.Round(someBaseValue * 10 + 3, 2);
            }
            else if (clientType.Equals("ClientType3", StringComparison.OrdinalIgnoreCase))
            {
                return Math.Round(someBaseValue + 2, 2);
            }

            throw new NotSupportedException();
        }
    }
}
