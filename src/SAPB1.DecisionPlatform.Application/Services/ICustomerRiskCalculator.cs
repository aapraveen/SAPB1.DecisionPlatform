using SAPB1.DecisionPlatform.Domain.Entities;

namespace SAPB1.DecisionPlatform.Application.Services;

public interface ICustomerRiskCalculator
{
    CustomerRiskProfile Calculate(CustomerRiskProfile profile);
}