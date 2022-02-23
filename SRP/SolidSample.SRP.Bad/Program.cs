using SolidSample.SRP.Bad;

var userService = new UserService();

Console.WriteLine("Calling UserService.Register method");
userService.Register("admin@local.com", "asd123");

try
{
    Console.WriteLine("Calling UserService.Register method");
    userService.Register("invalidEmail", "asd123");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}