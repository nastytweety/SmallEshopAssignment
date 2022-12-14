namespace SmallEshopAssignment.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string? Brand { get; set; }
        public string? DiscountedPrice { get; set; }
        public int Stock { get; set; }
        public int EShop_Status { get; set; }
    }
}
