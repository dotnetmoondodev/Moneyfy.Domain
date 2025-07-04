namespace Domain.Primitives;

public abstract record ValueEntity: BaseEntity
{
    public decimal Value { get; protected set; }

    internal ValueEntity() { }

    protected ValueEntity(
        string description,
        decimal value )
        : base( description )
    {
        Value = value;
    }
}
