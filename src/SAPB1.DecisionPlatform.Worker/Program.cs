using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SAPB1.DecisionPlatform.Application;
using SAPB1.DecisionPlatform.Infrastructure;
using SAPB1.DecisionPlatform.Infrastructure.Services;
using SAPB1.DecisionPlatform.Persistence;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddApplication();
        services.AddInfrastructure();
        services.AddPersistence();
    })
    .Build();

using var scope = host.Services.CreateScope();

var database = scope.ServiceProvider.GetRequiredService<IDatabaseService>();

Console.WriteLine("------------------------------------");
Console.WriteLine(" SAP B1 Decision Platform");
Console.WriteLine("------------------------------------");

if (await database.TestConnectionAsync())
{
    Console.WriteLine("✓ Connected to SAP HANA");

    var count = await database.GetCustomerCountAsync();

    Console.WriteLine($"Customers : {count}");
}
else
{
    Console.WriteLine("✗ Database connection failed");
}