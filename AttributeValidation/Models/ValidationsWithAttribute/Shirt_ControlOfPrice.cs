using System.ComponentModel.DataAnnotations;

namespace AttributeValidation.Models.ValidationsWithAttribute
{
    public class Shirt_ControlOfPrice:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt=validationContext.ObjectInstance as Shirt;
            if (shirt != null)
            {
                if (shirt.Price < 0)
                {
                    return new ValidationResult("Fiyat 0'dan küçük olamaz.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
