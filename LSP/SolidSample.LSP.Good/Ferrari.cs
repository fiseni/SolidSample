namespace SolidSample.LSP.Good
{
    public class Ferrari : Car, IAirConditionable
    {
        public void StartAirConditioning()
        {
            Console.WriteLine("Air conditioner started!");
        }
    }
}
