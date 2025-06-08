namespace Domain.Expenses;

public class NotFoundExpenseException( Guid id )
    : Exception( $"Expense with ID '{id}' not found." )
{ }
