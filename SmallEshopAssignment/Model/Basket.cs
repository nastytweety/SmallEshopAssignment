namespace SmallEshopAssignment.Model
{
    public class Basket
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
