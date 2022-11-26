using System.ComponentModel.DataAnnotations;

namespace EF6DataValidation.Models
{
    public class Phone
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Phone name cannot exceed 50 characters")]
        public string Name { get; set; }
        [Required]
        [Range(minimum: 10.0, maximum: 99.9, ErrorMessage = "Product price must be between $10.0 - $99.9")]
        public decimal Price { get; set; }
        [Required]
        [RegularExpression(pattern: @"\bApple|Google|Samsung\b", ErrorMessage = "We accept only Apple, Google and Samsung phone")]
        public string Brand { get; set; }
        public string Version { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string Model { get; set; }
    }
}
