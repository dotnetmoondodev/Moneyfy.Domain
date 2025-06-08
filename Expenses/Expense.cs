using Domain.Primitives;

namespace Domain.Expenses;

public sealed record Expense: ValueEntity
{
    private Expense() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Expense"/> class with the specified description and value.
    /// </summary>
    /// <remarks>The <see cref="Expense"/> class represents a financial expense with a description and a
    /// value. Ensure that the <paramref name="description"/> is meaningful and the <paramref name="value"/> is
    /// valid.</remarks>
    /// <param name="description">A brief description of the expense. Cannot be null or empty.</param>
    /// <param name="value">The monetary value of the expense. Must be a positive number.</param>
    public Expense(
        string description,
        decimal value )
        : base( description, value ) { }

    /// <summary>
    /// Updates the description and value of the current instance.
    /// </summary>
    /// <remarks>This method sets the <see cref="Description"/> and <see cref="Value"/> properties to the
    /// specified values. Ensure that the provided <paramref name="description"/> is meaningful and the <paramref
    /// name="value"/> is valid for the intended use case.</remarks>
    /// <param name="description">The new description to assign. Cannot be null or empty.</param>
    /// <param name="value">The new value to assign. Must be a non-negative decimal.</param>
    public void Update(
        string description,
        decimal value )
    {
        Description = description;
        Value = value;
    }
}
