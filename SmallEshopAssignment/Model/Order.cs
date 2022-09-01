namespace SmallEshopAssignment.Model
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; } 
        public ICollection<Product> Products { get; set; }
    }
}
