namespace Domain.Primitives;

using System.ComponentModel;

public static class CurrencyExtensions
{
    public static string GetDescription( this Currency value )
    {
        var field = value.GetType().GetField( value.ToString() );
        var attribute = field?.GetCustomAttributes( typeof( DescriptionAttribute ), false )
                              .FirstOrDefault() as DescriptionAttribute;
        return attribute?.Description ?? value.ToString();
    }
}

public static class CustomHoursExtensions
{
    public static string GetDescription( this CustomHours value )
    {
        var field = value.GetType().GetField( value.ToString() );
        var attribute = field?.GetCustomAttributes( typeof( DescriptionAttribute ), false )
                              .FirstOrDefault() as DescriptionAttribute;
        return attribute?.Description ?? value.ToString();
    }
}