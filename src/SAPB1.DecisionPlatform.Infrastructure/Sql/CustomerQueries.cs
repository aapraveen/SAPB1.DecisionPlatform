namespace SAPB1.DecisionPlatform.Infrastructure.Sql;

public static class CustomerQueries
{
    public const string GetCustomers =
    """
    SELECT
        CardCode,
        CardName,
        GroupCode,
        CreditLine AS CreditLimit,
        Balance,
        OrdersBal AS OrdersBalance,
        Currency,
        CASE
            WHEN FrozenFor='N'
            THEN TRUE
            ELSE FALSE
        END AS Active
    FROM OCRD
    WHERE CardType='C'
    ORDER BY CardCode
    """;
}