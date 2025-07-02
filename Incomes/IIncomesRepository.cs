using System.Linq.Expressions;

namespace Domain.Incomes;

public interface IIncomesRepository
{
    Task<Income?> GetByIdAsync( Guid id, CancellationToken cancellationToken );
    Task<Income?> GetByIdAsync( Expression<Func<Income, bool>> filter, CancellationToken cancellationToken );
    Task<IReadOnlyCollection<Income>> GetAllAsync( Expression<Func<Income, bool>>? filter, CancellationToken cancellationToken );
    Task AddAsync( Income income, CancellationToken cancellationToken );
    Task UpdateAsync( Income income, CancellationToken cancellationToken );
    Task DeleteAsync( Income income, CancellationToken cancellationToken );
}
