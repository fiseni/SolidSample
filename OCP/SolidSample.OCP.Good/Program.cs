using Microsoft.Extensions.DependencyInjection;
using SolidSample.OCP.Good;

var myCalculator = MyCalculatorFactory.Create();

Console.WriteLine("Using factory to create an instance of MyCalculator");
Console.WriteLine($"MyCalculator - The calculated price for ClientType1 is: {myCalculator.GetCalculatedPrice("ClientType1", 10)}");
Console.WriteLine($"MyCalculator - The calculated price for ClientType2 is: {myCalculator.GetCalculatedPrice("ClientType2", 10)}");
Console.WriteLine($"MyCalculator - The calculated price for ClientType3 is: {myCalculator.GetCalculatedPrice("ClientType3", 10)}");



var services = new ServiceCollection();
services.AddSingleton<IPriceCalculator, Type1Calculator>();
services.AddSingleton<IPriceCalculator, Type2Calculator>();
services.AddSingleton<IPriceCalculator, Type3Calculator>();
services.AddScoped<ICalculator, MyCalculator>();

var serviceProvider = services.BuildServiceProvider();
using (var scope = serviceProvider.CreateScope())
{
    var myCalculator2 = scope.ServiceProvider.GetService<ICalculator>();

    Console.WriteLine("Using IoC to create an instance of MyCalculator");
    Console.WriteLine($"MyCalculator - The calculated price for ClientType1 is: {myCalculator2!.GetCalculatedPrice("ClientType1", 10)}");
    Console.WriteLine($"MyCalculator - The calculated price for ClientType2 is: {myCalculator2!.GetCalculatedPrice("ClientType2", 10)}");
    Console.WriteLine($"MyCalculator - The calculated price for ClientType3 is: {myCalculator2!.GetCalculatedPrice("ClientType3", 10)}");
}