namespace Domain.Primitives;

public abstract record BaseEntity: IBaseEntity
{
    public Guid Id { get; protected set; }
    public string? Description { get; protected set; }
    public DateTime CreationDate { get; protected set; }

    internal BaseEntity() { }

    protected BaseEntity( string description )
    {
        Id = Guid.NewGuid();
        Description = description;
        CreationDate = DateTime.Now;
    }
}
