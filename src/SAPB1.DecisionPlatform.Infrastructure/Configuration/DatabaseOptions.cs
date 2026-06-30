namespace SAPB1.DecisionPlatform.Infrastructure.Configuration;

/// <summary>
/// SAP HANA connection settings.
/// </summary>
public sealed class DatabaseOptions
{
    public const string SectionName = "Database";

    public string Server { get; set; } = string.Empty;

    public int Port { get; set; }

    public string CompanyDB { get; set; } = string.Empty;

    public string UserName { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public bool Pooling { get; set; } = true;

    public int MaxPoolSize { get; set; } = 100;
}