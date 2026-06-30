using Microsoft.Extensions.DependencyInjection;

namespace SAPB1.DecisionPlatform.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        return services;
    }
}