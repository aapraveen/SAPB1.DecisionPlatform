using System.Threading;
using System.Threading.Tasks;

namespace SAPB1.DecisionPlatform.Infrastructure.Data.Repositories;

/// <summary>
/// Customer repository.
/// </summary>
public interface ICustomerRepository
{
    Task<int> GetCustomerCountAsync(
        CancellationToken cancellationToken = default);
}