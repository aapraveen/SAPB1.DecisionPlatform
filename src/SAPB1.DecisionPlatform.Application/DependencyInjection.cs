using Microsoft.Extensions.DependencyInjection;
using SAPB1.DecisionPlatform.Application.Services;

namespace SAPB1.DecisionPlatform.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICustomerRiskCalculator, CustomerRiskCalculator>();
        services.AddScoped<ICustomerRiskCalculator, CustomerRiskCalculator>();
        return services;
    }
}