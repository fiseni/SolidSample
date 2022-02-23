using SolidSample.OCP.Bad;

var myCalculator = new MyCalculator();

Console.WriteLine($"MyCalculator - The calculated price for ClientType1 is: {myCalculator.GetCalculatedPrice("ClientType1", 10)}");
Console.WriteLine($"MyCalculator - The calculated price for ClientType2 is: {myCalculator.GetCalculatedPrice("ClientType2", 10)}");
Console.WriteLine($"MyCalculator - The calculated price for ClientType3 is: {myCalculator.GetCalculatedPrice("ClientType3", 10)}");

var myBetterCalculator = new MyBetterCalculator();

Console.WriteLine($"MyBetterCalculator - The calculated price for ClientType1 is: {myBetterCalculator.GetCalculatedPrice("ClientType1", 10)}");
Console.WriteLine($"MyBetterCalculator - The calculated price for ClientType2 is: {myBetterCalculator.GetCalculatedPrice("ClientType2", 10)}");
Console.WriteLine($"MyBetterCalculator - The calculated price for ClientType3 is: {myBetterCalculator.GetCalculatedPrice("ClientType3", 10)}");