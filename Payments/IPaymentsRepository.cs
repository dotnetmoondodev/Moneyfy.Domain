namespace Domain.Payments;

public interface IPaymentsRepository
{
    Task<Payment?> GetByIdAsync( Guid id, CancellationToken cancellationToken );
    Task AddAsync( Payment payment, CancellationToken cancellationToken );
    Task UpdateAsync( Payment payment, CancellationToken cancellationToken );
    Task DeleteAsync( Payment payment, CancellationToken cancellationToken );
}
