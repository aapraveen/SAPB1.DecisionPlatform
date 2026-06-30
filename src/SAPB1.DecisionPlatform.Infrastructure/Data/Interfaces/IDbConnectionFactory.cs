using System.Data;

namespace SAPB1.DecisionPlatform.Infrastructure.Data.Interfaces;

/// <summary>
/// Creates database connections.
/// </summary>
public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}