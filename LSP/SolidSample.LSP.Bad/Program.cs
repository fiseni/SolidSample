using SolidSample.LSP.Bad;

Car car1 = new Mercedes();
Car car2 = new Trabant();

car1.Run();
car2.Run();

// This will work with no issues.
car1.StartAirConditioning();

try
{
    // This will throw an exception.
    // We're not expecting this to throw. That was not the original behavior of the parent.
    // We altered the original behavior in the inherited object.
    car2.StartAirConditioning();
}
catch (Exception)
{
    Console.WriteLine("An unexpected exception was thrown! We don't know why the behavior changed!");
}


foreach (var car in GetListOfCars())
{
    // As a consumer, we're getting list of Cars and we're not expecting this method to throw.
    // We have no knowledge whether there is a child type that broke this behavior
    try
    {
        car.StartAirConditioning();
    }
    catch (Exception)
    {
        Console.WriteLine("Some of the cars in the list threw an unexpected exception! We don't know why the behavior changed!");
    }
}

foreach (var car in GetListOfCars())
{
    // Whenever we see this kind of check in our code, it indicates that we're not adhering to LSP.
    // We are aware that some of the child objects have broken the original behavior, and we're guarding ourself.
    if (car is not Trabant)
    {
        car.StartAirConditioning();
    }
}

List<Car> GetListOfCars()
{
    return new List<Car>()
    {
        new Car(),
        new Mercedes(),
        new Trabant(),
    };
}