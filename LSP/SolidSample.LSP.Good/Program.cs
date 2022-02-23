using SolidSample.LSP.Good;

Car car1 = new Mercedes();
Car car2 = new Ferrari();
Car car3 = new Trabant();

car1.Run();
car2.Run();
car3.Run();

// We no longer can call StartAirConditioning on Car.
// That's not a generic behavior that all cars have. Some of them might not have that functionality.
// car3.StartAirConditioning();

foreach (var car in GetListOfAirConditionaleCars())
{
    car.StartAirConditioning();
}

List<IAirConditionable> GetListOfAirConditionaleCars()
{
    return new List<IAirConditionable>()
    {
        new Mercedes(),
        new Ferrari(),
    };
}