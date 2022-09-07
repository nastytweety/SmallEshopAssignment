using SmallEshopAssignment.Model;
using SmallEshopAssignment.Repositories;

namespace SmallEshopAssignment.Services
{
    public class CatalogueService : ICatalogueService
    {
        private readonly UnitOfWork _unitOfWork;

        public CatalogueService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            products.AddRange(_unitOfWork.Products.Find(x => x.Stock > 0 && x.EShop_Status == 1));
            products.AddRange(_unitOfWork.Products.Find(x => x.Stock > 2 && x.EShop_Status == 2));
            products.AddRange(_unitOfWork.Products.Find(x=>x.EShop_Status == 3));
            return products;
        }
    }
}
