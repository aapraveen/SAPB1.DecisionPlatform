namespace SAPB1.DecisionPlatform.Infrastructure.Services;

public interface IDatabaseService
{
    Task<bool> TestConnectionAsync();

    Task<int> GetCustomerCountAsync();
}