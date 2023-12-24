using System.ComponentModel.DataAnnotations;

namespace AttributeValidation.Models.ValidationsWithAttribute
{
    public class Shirt_ControlOfBrand:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt=validationContext.ObjectInstance as Shirt;
            if (shirt != null && string.IsNullOrEmpty(shirt.Brand))
            {
                return new ValidationResult("Marka alanı boş olmamalı.");
            }
            return ValidationResult.Success;
        }
    }
}
