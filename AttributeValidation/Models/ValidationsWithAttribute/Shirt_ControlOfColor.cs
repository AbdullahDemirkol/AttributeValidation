using System.ComponentModel.DataAnnotations;

namespace AttributeValidation.Models.ValidationsWithAttribute
{
    public class Shirt_ControlOfColor : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt = validationContext.ObjectInstance as Shirt;
            if (shirt != null && string.IsNullOrEmpty(shirt.Color))
            {
                return new ValidationResult("Renk alanı boş olmamalı.");
            }
            return ValidationResult.Success;
        }
    }
}
