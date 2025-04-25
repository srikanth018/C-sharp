using System.ComponentModel.DataAnnotations;

namespace ECommerce.DTOs
{
    public class UpdateProductDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Should be Positive")]
        public int? Stock { get; set; }

    }
}
