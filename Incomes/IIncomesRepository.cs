namespace Domain.Incomes;

public interface IIncomesRepository
{
    Task<Income?> GetByIdAsync( Guid id, CancellationToken cancellationToken );
    Task AddAsync( Income income, CancellationToken cancellationToken );
    Task UpdateAsync( Income income, CancellationToken cancellationToken );
    Task DeleteAsync( Income income, CancellationToken cancellationToken );
}
