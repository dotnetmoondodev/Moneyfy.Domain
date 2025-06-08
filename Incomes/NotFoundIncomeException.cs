namespace Domain.Incomes;

public class NotFoundIncomeException( Guid id )
    : Exception( $"Income with ID {id} not found." )
{ }
