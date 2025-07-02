using System.Linq.Expressions;

namespace Domain.Payments;

public interface IPaymentsRepository
{
    Task<Payment?> GetByIdAsync( Guid id, CancellationToken cancellationToken );
    Task<Payment?> GetByIdAsync( Expression<Func<Payment, bool>> filter, CancellationToken cancellationToken );
    Task<IReadOnlyCollection<Payment>> GetAllAsync( Expression<Func<Payment, bool>>? filter, CancellationToken cancellationToken );
    Task AddAsync( Payment payment, CancellationToken cancellationToken );
    Task UpdateAsync( Payment payment, CancellationToken cancellationToken );
    Task DeleteAsync( Payment payment, CancellationToken cancellationToken );
}
