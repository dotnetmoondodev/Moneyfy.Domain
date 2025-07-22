using System.ComponentModel;

namespace Domain.Primitives;

public enum Currency: byte
{
    [Description( "USD - United States Dollar" )]
    USD = 1, // United States Dollar

    [Description( "EUR - Euro" )]
    EUR = 2, // Euro

    [Description( "COP - Colombian Peso" )]
    COP = 3, // Colombian Peso

    [Description( "GBP - British Pound Sterling" )]
    GBP = 4, // British Pound Sterling

    [Description( "JPY - Japanese Yen" )]
    JPY = 5, // Japanese Yen

    [Description( "AUD - Australian Dollar" )]
    AUD = 6, // Australian Dollar

    [Description( "CAD - Canadian Dollar" )]
    CAD = 7, // Canadian Dollar

    [Description( "CHF - Swiss Franc" )]
    CHF = 8, // Swiss Franc

    [Description( "CNY - Chinese Yuan" )]
    CNY = 9  // Chinese Yuan
}
