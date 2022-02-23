namespace SolidSample.OCP.Good
{
    public class MyCalculator : ICalculator
    {
        private readonly IEnumerable<IPriceCalculator> _priceCalculators;

        public MyCalculator(IEnumerable<IPriceCalculator> priceCalculators)
        {
            _priceCalculators = priceCalculators;
        }

        public decimal GetCalculatedPrice(string clientType, decimal someBaseValue)
        {
            var calculator = _priceCalculators.FirstOrDefault(x => x.ClientType == clientType);

            if (calculator is not null)
            {
                return calculator.GetPrice(someBaseValue);
            }

            throw new NotSupportedException();
        }
    }
}
