using Microsoft.Extensions.Options;
using SAPB1.DecisionPlatform.Infrastructure.Configuration;
using SAPB1.DecisionPlatform.Infrastructure.Data.Interfaces;
using System.Data;

namespace SAPB1.DecisionPlatform.Infrastructure.Data.Connection;

public sealed class HanaConnectionFactory : IDbConnectionFactory
{
    private readonly DatabaseOptions _options;

    public HanaConnectionFactory(
        IOptions<DatabaseOptions> options)
    {
        _options = options.Value;
    }

    public IDbConnection CreateConnection()
    {
        string connectionString =
            $"Server={_options.Server}:{_options.Port};" +
            $"UserID={_options.UserName};" +
            $"Password={_options.Password};" +
            $"Current Schema={_options.CompanyDB};" +
            $"Pooling={_options.Pooling};" +
            $"Maximum Pool Size={_options.MaxPoolSize};";

        throw new NotImplementedException(connectionString);
    }
}