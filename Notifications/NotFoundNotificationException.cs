namespace Domain.Notifications;

public class NotFoundNotificationException( Guid id )
    : Exception( $"Notification with ID '{id}' not found." )
{ }
