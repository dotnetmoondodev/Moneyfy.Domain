namespace Domain;

public interface IRepository<T>
{
    Task<IReadOnlyCollection<T>> GetAllAsync( CancellationToken cancellationToken );
    Task<T?> GetByIdAsync( Guid id, CancellationToken cancellationToken );
    Task AddAsync( T entity, CancellationToken cancellationToken );
    Task UpdateAsync( T entity, CancellationToken cancellationToken );
    Task DeleteAsync( T entity, CancellationToken cancellationToken );
}
