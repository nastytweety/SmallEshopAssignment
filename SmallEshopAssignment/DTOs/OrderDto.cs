using SmallEshopAssignment.Model;
using System.ComponentModel.DataAnnotations;

namespace SmallEshopAssignment.DTOs
{
    public class OrderDto
    {
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public ICollection<Product> Products { get; set; }
    }
}
