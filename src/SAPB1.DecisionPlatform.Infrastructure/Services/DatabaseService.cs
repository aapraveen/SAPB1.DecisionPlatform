using Dapper;
using SAPB1.DecisionPlatform.Infrastructure.Data.Interfaces;

namespace SAPB1.DecisionPlatform.Infrastructure.Services;

public sealed class DatabaseService : IDatabaseService
{
    private readonly IDbConnectionFactory _connectionFactory;

    public DatabaseService(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<bool> TestConnectionAsync()
    {
        try
        {
            using var connection = _connectionFactory.CreateConnection();

            connection.Open();

            return connection.State == System.Data.ConnectionState.Open;
        }
        catch
        {
            return false;
        }
    }

    public async Task<int> GetCustomerCountAsync()
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