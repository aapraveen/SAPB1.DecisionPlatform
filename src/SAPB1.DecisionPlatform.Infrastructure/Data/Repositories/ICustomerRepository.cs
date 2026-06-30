using SAPB1.DecisionPlatform.Infrastructure.Models;

namespace SAPB1.DecisionPlatform.Infrastructure.Data.Repositories;

public interface ICustomerRepository
{
    Task<IReadOnlyList<CustomerDto>> GetCustomersAsync(
        CancellationToken cancellationToken = default);
}