using AttributeValidation.Models.ValidationsWithAttribute;
using System.ComponentModel.DataAnnotations;

namespace AttributeValidation.Models
{
    public class Shirt
    {
        public int ShirtId { get; set; }
        [Required]
        [Shirt_ControlOfBrand]
        public string Brand { get; set; }
        [Required]
        [Shirt_ControlOfColor]
        public string Color { get; set; }
        [Required]
        [Shirt_EnsureCorrectSizing]
        public int Size { get; set; }
        [Required]
        [Shirt_ControlOfGender]
        public string Gender { get; set; }
        [Required]
        [Shirt_ControlOfPrice]
        public double Price { get; set; }
    }
}
