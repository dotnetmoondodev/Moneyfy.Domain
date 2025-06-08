namespace Domain.Notifications;

public interface INotificationsRepository
{
    Task<Notification?> GetByIdAsync( Guid id, CancellationToken cancellationToken );
    Task AddAsync( Notification notification, CancellationToken cancellationToken );
    Task UpdateAsync( Notification notification, CancellationToken cancellationToken );
    Task DeleteAsync( Notification notification, CancellationToken cancellationToken );
}
