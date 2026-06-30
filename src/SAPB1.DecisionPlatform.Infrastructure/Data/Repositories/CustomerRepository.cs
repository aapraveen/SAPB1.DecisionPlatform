using Dapper;
using SAPB1.DecisionPlatform.Infrastructure.Data.Interfaces;

namespace SAPB1.DecisionPlatform.Infrastructure.Data.Repositories;

/// <summary>
/// Customer repository.
/// </summary>
public sealed class CustomerRepository : ICustomerRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public CustomerRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<int> GetCustomerCountAsync(
        CancellationToken cancellationToken = default)
    {
        using var connection = _connectionFactory.CreateConnection();

        const string sql = """
            SELECT COUNT(*)
            FROM OCRD
            WHERE CardType='C'
            """;

        return await connection.ExecuteScalarAsync<int>(sql);
    }
}