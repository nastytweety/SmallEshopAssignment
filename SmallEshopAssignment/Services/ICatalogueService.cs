using SmallEshopAssignment.Model;

namespace SmallEshopAssignment.Services
{
    public interface ICatalogueService
    {
        IEnumerable<Product> GetProducts();
    }
}
