using Microsoft.Extensions.DependencyInjection;
using SolidSample.DIP.Good;

var emailSender = new EmailSender();
var orderService = new OrderService(emailSender);

orderService.CompleteOrder();


Console.WriteLine("Using IoC to construct the order service.");
var services = new ServiceCollection();
services.AddScoped<IEmailSender, EmailSender>(); // We can easily switch the implementation, e.g. instead of SMTP client, we might use some online email service.
services.AddScoped<OrderService>();

var serviceProvider = services.BuildServiceProvider();
using (var scope = serviceProvider.CreateScope())
{
    var orderService2 = scope.ServiceProvider.GetService<OrderService>();
    orderService2!.CompleteOrder();
}