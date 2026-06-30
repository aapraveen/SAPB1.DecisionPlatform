namespace SAPB1.DecisionPlatform.Domain.ValueObjects;

/// <summary>
/// Represents a validated risk score.
/// </summary>
public readonly struct RiskScore
{
    public int Value { get; }

    public RiskScore(int value)
    {
        if (value < 0 || value > 100)
            throw new ArgumentOutOfRangeException(nameof(value));

        Value = value;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}