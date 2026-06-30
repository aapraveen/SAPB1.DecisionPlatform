using Microsoft.Extensions.Hosting;
using SAPB1.DecisionPlatform.Application;
using SAPB1.DecisionPlatform.Infrastructure;
using SAPB1.DecisionPlatform.Persistence;

Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddApplication();
        services.AddInfrastructure();
        services.AddPersistence();
    })
    .Build()
    .Run();