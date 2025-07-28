using System.Diagnostics;
using Domain.Primitives;

namespace Domain.Payments;

[DebuggerDisplay( "Payment {Id}: {Description} - {Value}" )]
public sealed record Payment: ValueEntity
{
    public Currency Currency { get; private set; }
    public CustomAnswer IsAutoDebit { get; private set; }
    public string? PaymentMediaReference { get; private set; }

    private Payment() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Payment"/> class with the specified details.
    /// </summary>
    /// <remarks>This constructor initializes the payment with the provided details, including the
    /// description, value, currency, auto-debit, and payment media reference.
    /// Ensure all parameters meet their respective preconditions to avoid exceptions.</remarks>
    /// <param name="description">A brief description of the payment. This value cannot be null or empty.</param>
    /// <param name="value">The monetary value of the payment. Must be a positive decimal value.</param>
    /// <param name="currency">The currency in which the payment is made. This value cannot be null.</param>
    /// <param name="isAutoDebit">A value indicating whether the payment is set up for automatic debit.
    /// <see langword="true"/> if the payment is an auto-debit; otherwise, <see langword="false"/>.</param>
    /// <param name="paymentMediaReference">A reference to the payment media used for the transaction, such as a
    /// card or account identifier. This value cannot be null or empty.</param>
    public Payment(
        string description,
        decimal value,
        Currency currency,
        CustomAnswer isAutoDebit,
        string? paymentMediaReference )
        : base( description, value )
    {
        Currency = currency;
        IsAutoDebit = isAutoDebit;
        PaymentMediaReference = paymentMediaReference;
    }

    /// <summary>
    /// Updates the properties of the payment with the specified values.
    /// </summary>
    /// <remarks>This method updates the payment details by assigning the provided values to the corresponding
    /// properties. Ensure that all parameters meet their respective preconditions to avoid runtime errors.</remarks>
    /// <param name="description">The description of the payment. Cannot be null or empty.</param>
    /// <param name="value">The monetary value of the payment. Must be a positive decimal.</param>
    /// <param name="currency">The currency in which the payment is made. Cannot be null.</param>
    /// <param name="isAutoDebit">A value indicating whether the payment is set to auto-debit.
    /// <see langword="true"/> if auto-debit is enabled; otherwise, <see langword="false"/>.</param>
    /// <param name="paymentMediaReference">A reference to the payment media used for the transaction.
    /// Cannot be null or empty.</param>
    public void Update(
        string description,
        decimal value,
        Currency currency,
        CustomAnswer isAutoDebit,
        string? paymentMediaReference )
    {
        Description = description;
        Value = value;
        Currency = currency;
        IsAutoDebit = isAutoDebit;
        PaymentMediaReference = paymentMediaReference;
    }
}
