using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SmallEshopAssignment.DTOs
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Brand { get; set; }
        public string? DiscountedPrice { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        [Range(1, 3, ErrorMessage = "(Allowed Values 1, 2 & 3)")]
        public int EShop_Status { get; set; }
    }
}

