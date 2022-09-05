using SmallEshopAssignment.Model;

namespace SmallEshopAssignment.DTOs
{
    public class BasketDto
    {
        public ICollection<Product> Products { get; set; }
    }
}
