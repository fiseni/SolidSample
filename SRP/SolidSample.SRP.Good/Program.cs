using SolidSample.SRP.Good;

var emailSender = new EmailSender();
var userService = new UserCreator(emailSender);

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