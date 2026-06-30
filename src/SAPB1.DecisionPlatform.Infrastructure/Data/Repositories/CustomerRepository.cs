using Dapper;
using SAPB1.DecisionPlatform.Infrastructure.Data.Interfaces;
using SAPB1.DecisionPlatform.Infrastructure.Models;
using SAPB1.DecisionPlatform.Infrastructure.Sql;

namespace SAPB1.DecisionPlatform.Infrastructure.Data.Repositories;

public sealed class CustomerRepository : ICustomerRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public CustomerRepository(
        IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<IReadOnlyList<CustomerDto>> GetCustomersAsync(
    CancellationToken cancellationToken = default)
    {
        using var connection = _connectionFactory.CreateConnection();

        var customers = await connection.QueryAsync<CustomerDto>(
            CustomerQueries.GetCustomers);

        return customers.AsList();
    }
}