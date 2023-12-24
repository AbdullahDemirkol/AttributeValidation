using System.Collections.Frozen;
using System.ComponentModel.DataAnnotations;

namespace AttributeValidation.Models.ValidationsWithAttribute
{
    public class Shirt_ControlOfGender:ValidationAttribute
    {
        private readonly FrozenSet<string> genders;
        public Shirt_ControlOfGender()
        {
            var list = new List<string>() { "bay", "bayan", "çocuk" };
            genders = list.ToFrozenSet();
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt = validationContext.ObjectInstance as Shirt;
            if (shirt != null && !string.IsNullOrEmpty(shirt.Gender))
            {
                if (!genders.Any(p=>p == shirt.Gender.ToLower()))
                {
                    return new ValidationResult("Gender kategorisi bulunamadı.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
