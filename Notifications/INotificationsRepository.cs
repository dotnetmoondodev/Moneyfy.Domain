using System.Linq.Expressions;

namespace Domain.Notifications;

public interface INotificationsRepository
{
    Task<Notification?> GetByIdAsync( Guid id, CancellationToken cancellationToken );
    Task<Notification?> GetByIdAsync( Expression<Func<Notification, bool>> filter, CancellationToken cancellationToken );
    Task<IReadOnlyCollection<Notification>> GetAllAsync( Expression<Func<Notification, bool>>? filter, CancellationToken cancellationToken );
    Task AddAsync( Notification notification, CancellationToken cancellationToken );
    Task UpdateAsync( Notification notification, CancellationToken cancellationToken );
    Task DeleteAsync( Notification notification, CancellationToken cancellationToken );
}
