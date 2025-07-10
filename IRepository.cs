using System.Linq.Expressions;

namespace Domain;

public interface IRepository<T>
{
    Task<T?> GetByIdAsync( Guid id, CancellationToken cancellationToken );
    Task<T?> GetByIdAsync( Expression<Func<T, bool>> filter, CancellationToken cancellationToken );
    Task<IReadOnlyCollection<T>> GetAllAsync( Expression<Func<T, bool>>? filter, CancellationToken cancellationToken );
    Task AddAsync( T entity, CancellationToken cancellationToken );
    Task UpdateAsync( T entity, CancellationToken cancellationToken );
    Task DeleteAsync( T entity, CancellationToken cancellationToken );
}
