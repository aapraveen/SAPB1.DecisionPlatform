using System.Data;
using SAPB1.DecisionPlatform.Infrastructure.Data.Interfaces;

namespace SAPB1.DecisionPlatform.Infrastructure.Data.Connection;

/// <summary>
/// SAP HANA connection factory.
/// </summary>
public sealed class HanaConnectionFactory : IDbConnectionFactory
{
    public IDbConnection CreateConnection()
    {
        throw new NotImplementedException(
            "SAP HANA provider will be added in the next commit.");
    }
}