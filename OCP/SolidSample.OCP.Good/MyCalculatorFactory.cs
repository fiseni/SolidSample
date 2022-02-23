namespace SolidSample.OCP.Good
{
    public class MyCalculatorFactory
    {
        public static MyCalculator Create()
        {
            var priceCalculators = new List<IPriceCalculator>()
            {
                new Type1Calculator(),
                new Type2Calculator(),
                new Type3Calculator()
            };

            return new MyCalculator(priceCalculators);
        }
    }
}
