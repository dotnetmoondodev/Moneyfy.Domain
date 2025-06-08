using Domain.Primitives;

namespace Domain.Incomes;

public sealed record Income: ValueEntity
{
    public string? Source { get; private set; }
    public decimal Withholding { get; private set; }

    private Income() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Income"/> class with the specified description,
    /// value, source, and withholding amount.
    /// </summary>
    /// <remarks>The <paramref name="withholding"/> parameter represents deductions applied to the income, and
    /// it should not exceed the <paramref name="value"/>.</remarks>
    /// <param name="description">A brief description of the income. Cannot be null or empty.</param>
    /// <param name="value">The monetary value of the income. Must be greater than or equal to zero.</param>
    /// <param name="source">The source of the income, such as an employer or organization. Cannot be null or empty.</param>
    /// <param name="withholding">The amount withheld from the income, typically for taxes or other deductions.
    /// Must be greater than or equal to zero.</param>
    public Income(
        string description,
        decimal value,
        string? source,
        decimal withholding )
        : base( description, value )
    {
        Source = source;
        Withholding = withholding;
    }

    /// <summary>
    /// Updates the properties of the current instance with the specified values.
    /// </summary>
    /// <remarks>This method assigns the provided values to the corresponding properties of the instance. 
    /// Ensure that all parameters meet their respective constraints to avoid invalid state.</remarks>
    /// <param name="description">The description to associate with the instance. Cannot be null or empty.</param>
    /// <param name="value">The monetary value to set. Must be a non-negative decimal.</param>
    /// <param name="source">The source of the value. Cannot be null or empty.</param>
    /// <param name="withholding">The withholding amount to set. Must be a non-negative decimal.</param>
    public void Update(
        string description,
        decimal value,
        string? source,
        decimal withholding )
    {
        Description = description;
        Value = value;
        Source = source;
        Withholding = withholding;
    }
}
