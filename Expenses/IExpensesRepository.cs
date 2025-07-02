using System.Linq.Expressions;

namespace Domain.Expenses;

public interface IExpensesRepository
{
    Task<Expense?> GetByIdAsync( Guid id, CancellationToken cancellationToken );
    Task<Expense?> GetByIdAsync( Expression<Func<Expense, bool>> filter, CancellationToken cancellationToken );
    Task<IReadOnlyCollection<Expense>> GetAllAsync( Expression<Func<Expense, bool>>? filter, CancellationToken cancellationToken );
    Task AddAsync( Expense expense, CancellationToken cancellationToken );
    Task UpdateAsync( Expense expense, CancellationToken cancellationToken );
    Task DeleteAsync( Expense expense, CancellationToken cancellationToken );
}
