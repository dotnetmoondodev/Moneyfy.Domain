using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Domain.Notifications;

[AttributeUsage( AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false )]
public class EmailRequiredAttribute( string dependentProperty, object targetValue ): ValidationAttribute
{
    protected override ValidationResult IsValid( object? value, ValidationContext validationContext )
    {
        var otherPropertyValue = validationContext.ObjectType
            .GetProperty( dependentProperty )?
            .GetValue( validationContext.ObjectInstance );

        if ( otherPropertyValue is null || !otherPropertyValue.Equals( targetValue ) )
            return ValidationResult.Success!;

        if ( value is null || string.IsNullOrWhiteSpace( value.ToString() ) )
        {
            return new ValidationResult( ErrorMessage ?? $"The {validationContext.DisplayName} is required." );
        }

        if ( value == null )
        {
            return ValidationResult.Success!;
        }

        if ( value is not string valueAsString )
        {
            return new ValidationResult( ErrorMessage ?? $"The {validationContext.DisplayName} is not valid." );
        }

        if ( valueAsString.AsSpan().ContainsAny( '\r', '\n' ) )
        {
            return new ValidationResult( ErrorMessage ?? $"The {validationContext.DisplayName} is not valid." );
        }

        var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch( valueAsString, emailPattern ) ? ValidationResult.Success! :
            new ValidationResult( ErrorMessage ?? $"The {validationContext.DisplayName} must be a valid email address." );
    }
}

[AttributeUsage( AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false )]
public class PhoneRequiredAttribute( string dependentProperty, object[] targetValue ): ValidationAttribute
{
    protected override ValidationResult IsValid( object? value, ValidationContext validationContext )
    {
        var otherPropertyValue = validationContext.ObjectType
            .GetProperty( dependentProperty )?
            .GetValue( validationContext.ObjectInstance );

        if ( otherPropertyValue is null || !targetValue.Contains( otherPropertyValue ) )
            return ValidationResult.Success!;

        if ( value is null || string.IsNullOrWhiteSpace( value.ToString() ) )
        {
            return new ValidationResult( ErrorMessage ?? $"The {validationContext.DisplayName} is required." );
        }

        if ( value == null )
        {
            return ValidationResult.Success!;
        }

        if ( value is not string valueAsString )
        {
            return new ValidationResult( ErrorMessage ?? $"The {validationContext.DisplayName} is not valid." );
        }

        var phonePattern = @"^\+?[1-9]\d{9,14}$";
        return Regex.IsMatch( valueAsString, phonePattern ) ? ValidationResult.Success! :
            new ValidationResult( ErrorMessage ?? $"The {validationContext.DisplayName} must be a valid phone number." );
    }
}