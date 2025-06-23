using Domain.Payments;
using Domain.Primitives;

namespace Domain.Notifications;

public sealed record Notification: BaseEntity
{
    public DateTime DateToSend { get; private set; }
    public CustomHours HourToSend { get; private set; }
    public NotificationFrequency Frequency { get; private set; }
    public NotificationMethod Method { get; private set; }
    public Guid? PaymentId { get; private set; }
    public Payment? Payment { get; private set; }
    public CustomAnswer Repeatable { get; private set; }
    public CustomAnswer Enable { get; private set; }
    public string? Email { get; private set; }
    public string? PhoneNumber { get; private set; }

    private Notification() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Notification"/> class, representing a scheduled notification with
    /// specified delivery details and configuration options.
    /// </summary>
    /// <remarks>This constructor allows for detailed configuration of a notification, including scheduling,
    /// delivery method, and recurrence. Ensure that the provided parameters meet the expected constraints to avoid runtime errors.</remarks>
    /// <param name="description">The description of the notification. This provides context or details about the notification's purpose.</param>
    /// <param name="dateToSend">The date on which the notification is scheduled to be sent. Must be a valid <see cref="DateTime"/> value.</param>
    /// <param name="hourToSend">The hour of the day (in 24-hour format) when the notification is scheduled to be sent.
    /// Must be a valid <see cref="CustomHours"/> value.</param>
    /// <param name="frequency">The frequency with which the notification should be sent. Must be a valid <see cref="NotificationFrequency"/> value.
    /// This determines the recurrence pattern of the notification.</param>
    /// <param name="method">The method by which the notification will be delivered, such as email or SMS.
    /// Must be a valid <see cref="NotificationMethod"/> value.</param>
    /// <param name="paymentId">The identifier for the associated payment, if applicable. This can be used to link the notification to a
    /// specific transaction.</param>
    /// <param name="repeatable">A value indicating whether the notification is repeatable. 
    /// Must be a valid <see cref="CustomAnswer"/> value.</param>
    /// <param name="enable">A value indicating whether the notification is enabled. 
    /// Must be a valid <see cref="CustomAnswer"/> value.</param>
    /// <param name="email">The email address to which the notification will be sent, if the delivery method is email. Can be <see
    /// langword="null"/> or empty if not applicable.</param>
    /// <param name="phoneNumber">The phone number to which the notification will be sent, if the delivery method is SMS. Can be <see
    /// langword="null"/> or empty if not applicable.</param>
    public Notification(
        string description,
        DateTime dateToSend,
        CustomHours hourToSend,
        NotificationFrequency frequency,
        NotificationMethod method,
        Guid? paymentId,
        CustomAnswer repeatable,
        CustomAnswer enable,
        string? email,
        string? phoneNumber )
        : base( description )
    {
        DateToSend = dateToSend;
        HourToSend = hourToSend;
        Frequency = frequency;
        Method = method;
        PaymentId = paymentId;
        Repeatable = repeatable;
        Enable = enable;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    /// <summary>
    /// Updates the notification settings with the specified parameters.
    /// </summary>
    /// <remarks>This method updates all relevant properties of the notification based on the provided
    /// parameters. Ensure that the parameters meet the required constraints to avoid runtime errors.</remarks>
    /// <param name="description">A brief description of the notification. Cannot be null or empty.</param>
    /// <param name="dateToSend">The date on which the notification should be sent. Must be a valid <see cref="DateTime"/> value.</param>
    /// <param name="hourToSend">The hour of the day (0-23) at which the notification should be sent. Must be within the valid range.</param>
    /// <param name="frequency">The frequency at which the notification should be sent. Must be a valid <see cref="NotificationFrequency"/>
    /// value.</param>
    /// <param name="method">The method by which the notification will be sent (e.g., email, SMS). Must be a valid <see
    /// cref="NotificationMethod"/> value.</param>
    /// <param name="paymentId">The identifier for the associated payment.</param>
    /// <param name="repeatable">A value indicating whether the notification is repeatable. 
    /// Must be a valid <see cref="CustomAnswer"/> value.</param>
    /// <param name="enable">A value indicating whether the notification is enabled. 
    /// Must be a valid <see cref="CustomAnswer"/> value.</param>
    /// <param name="email">The email address to which the notification will be sent. Cannot be null or empty if <paramref name="method"/>
    /// is set to email.</param>
    /// <param name="phoneNumber">The phone number to which the notification will be sent. Cannot be null or empty if <paramref name="method"/> is
    /// set to SMS.</param>
    public void Update(
        string description,
        DateTime dateToSend,
        CustomHours hourToSend,
        NotificationFrequency frequency,
        NotificationMethod method,
        Guid? paymentId,
        CustomAnswer repeatable,
        CustomAnswer enable,
        string? email,
        string? phoneNumber )
    {
        Description = description;
        DateToSend = dateToSend;
        HourToSend = hourToSend;
        Frequency = frequency;
        Method = method;
        PaymentId = paymentId;
        Repeatable = repeatable;
        Enable = enable;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}
