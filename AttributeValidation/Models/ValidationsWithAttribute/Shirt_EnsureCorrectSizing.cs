using System.ComponentModel.DataAnnotations;

namespace AttributeValidation.Models.ValidationsWithAttribute
{
    public class Shirt_EnsureCorrectSizing:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt=validationContext.ObjectInstance as Shirt;
            if (shirt != null && !string.IsNullOrEmpty(shirt.Gender))
            {
                if (shirt.Gender.Equals("bay",StringComparison.OrdinalIgnoreCase) && shirt.Size<8) 
                {
                    return new ValidationResult("Erkekler için tişört boyu 8'den büyük olmalıdır.");
                }
                else if (shirt.Gender.Equals("bayan",StringComparison.OrdinalIgnoreCase) && shirt.Size<6)
                {
                    return new ValidationResult("Kadınlar için tişört boyu 6'dan büyük olmalıdır.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
