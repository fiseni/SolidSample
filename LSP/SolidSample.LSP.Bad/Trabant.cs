namespace SolidSample.LSP.Bad
{
    public class Trabant : Car
    {
        public override void StartAirConditioning()
        {
            throw new NotSupportedException("There is no air conditioner in this car!");
        }
    }
}
