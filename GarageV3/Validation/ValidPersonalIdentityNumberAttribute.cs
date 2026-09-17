using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;

namespace GarageV3.Validation;

public class ValidPersonalIdentityNumberAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(
    object? value,
    ValidationContext validationContext)
    {
        if (value is not string pin || string.IsNullOrWhiteSpace(pin))
        {
            return new ValidationResult("Personal identity number is required.");
        }

        string normalized = pin.Trim();

        // Exact format: YYYYMMDD-XXXX
        if (!Regex.IsMatch(normalized, @"^\d{8}-\d{4}$"))
        {
            return new ValidationResult(
                "Personal identity number must follow the format YYYYMMDD-XXXX.");
        }

        string datePart = normalized[..8];

        if (!DateTime.TryParseExact(
            datePart,
            "yyyyMMdd",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out _))
        {
            return new ValidationResult(
                "Personal identity number must contain a valid date.");
        }

        return ValidationResult.Success;
    }
}
