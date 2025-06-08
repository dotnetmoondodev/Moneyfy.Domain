namespace Domain.Primitives;

public interface IBaseEntity
{
    Guid Id { get; }
    string? Description { get; }
}
