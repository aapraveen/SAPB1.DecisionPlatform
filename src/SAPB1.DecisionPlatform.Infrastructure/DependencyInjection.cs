using Microsoft.Extensions.DependencyInjection;
using SAPB1.DecisionPlatform.Infrastructure.Data.Connection;
using SAPB1.DecisionPlatform.Infrastructure.Data.Interfaces;
using SAPB1.DecisionPlatform.Infrastructure.Data.Repositories;

namespace SAPB1.DecisionPlatform.Infrastructure;

/// <summary>
/// Infrastructure dependency registration.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddSingleton<IDbConnectionFactory, HanaConnectionFactory>();

        services.AddScoped<ICustomerRepository, CustomerRepository>();

        return services;
    }
}