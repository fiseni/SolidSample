namespace SolidSample.LSP.Good
{
    public class Mercedes : Car, IAirConditionable
    {
        public void StartAirConditioning()
        {
            Console.WriteLine("Air conditioner started!");
        }
    }
}
