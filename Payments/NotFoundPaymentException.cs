namespace Domain.Payments;

public class NotFoundPaymentException( Guid id )
    : Exception( $"Payment with ID {id} not found." )
{ }
