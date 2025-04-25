using System.ComponentModel.DataAnnotations;

namespace ECommerce.DTOs
{
    public class AddProductDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Should be Positive")]
        public int Stock { get; set; }
    }
}
