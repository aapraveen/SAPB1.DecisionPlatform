namespace SAPB1.DecisionPlatform.Infrastructure.Models;

public sealed class CustomerDto
{
    public string CardCode { get; set; } = string.Empty;

    public string CardName { get; set; } = string.Empty;

    public int GroupCode { get; set; }

    public decimal CreditLimit { get; set; }

    public decimal Balance { get; set; }

    public decimal OrdersBalance { get; set; }

    public string Currency { get; set; } = string.Empty;

    public bool Active { get; set; }
}