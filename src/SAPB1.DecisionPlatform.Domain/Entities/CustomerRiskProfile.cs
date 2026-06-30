using SAPB1.DecisionPlatform.Domain.Enums;
using SAPB1.DecisionPlatform.Domain.ValueObjects;

namespace SAPB1.DecisionPlatform.Domain.Entities;

/// <summary>
/// Customer risk profile used by the Decision Engine.
/// </summary>
public sealed class CustomerRiskProfile
{
    public string CardCode { get; set; } = string.Empty;

    public string CardName { get; set; } = string.Empty;

    public decimal CreditLimit { get; set; }

    public decimal CurrentBalance { get; set; }

    public decimal OpenOrders { get; set; }

    public decimal OutstandingInvoices { get; set; }

    public int AveragePaymentDelayDays { get; set; }

    public decimal ReturnPercentage { get; set; }

    public decimal DeliveryPerformance { get; set; }

    public RiskScore Score { get; set; }

    public RiskLevel RiskLevel { get; set; }

    public DateTime LastCalculatedOn { get; set; }
}