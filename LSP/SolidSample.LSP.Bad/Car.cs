namespace SolidSample.LSP.Bad
{
    public class Car
    {
        public virtual void Run()
        {
            Console.WriteLine("Car started!");
        }

        public virtual void StartAirConditioning()
        {
            Console.WriteLine("Air conditioner started!");
        }
    }
}
