namespace SAPB1.DecisionPlatform.Domain.Entities;

/// <summary>
/// Base class for all entities.
/// </summary>
public abstract class BaseEntity
{
    public Guid Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }
}