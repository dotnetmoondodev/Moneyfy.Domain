namespace Domain.Expenses;

public interface IExpensesRepository
{
    Task<Expense?> GetByIdAsync( Guid id, CancellationToken cancellationToken );
    Task AddAsync( Expense expense, CancellationToken cancellationToken );
    Task UpdateAsync( Expense expense, CancellationToken cancellationToken );
    Task DeleteAsync( Expense expense, CancellationToken cancellationToken );
}
