using SAPB1.DecisionPlatform.Domain.Entities;
using SAPB1.DecisionPlatform.Domain.Enums;
using SAPB1.DecisionPlatform.Domain.ValueObjects;

namespace SAPB1.DecisionPlatform.Application.Services;

public sealed class CustomerRiskCalculator : ICustomerRiskCalculator
{
    public CustomerRiskProfile Calculate(CustomerRiskProfile profile)
    {
        int score = 100;

        if (profile.AveragePaymentDelayDays > 30)
            score -= 25;

        if (profile.ReturnPercentage > 10)
            score -= 20;

        if (profile.DeliveryPerformance < 80)
            score -= 15;

        if (profile.CurrentBalance > profile.CreditLimit)
            score -= 40;

        score = Math.Max(0, score);

        profile.Score = new RiskScore(score);

        profile.RiskLevel = score switch
        {
            >= 80 => RiskLevel.Low,
            >= 60 => RiskLevel.Medium,
            >= 40 => RiskLevel.High,
            _ => RiskLevel.Critical
        };

        profile.LastCalculatedOn = DateTime.UtcNow;

        return profile;
    }
}