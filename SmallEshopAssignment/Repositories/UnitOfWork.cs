using SmallEshopAssignment.Model;

namespace SmallEshopAssignment.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IBasketRepository Baskets { get; set; }
        public IProductRepository Products { get; set; }
        public IServiceRepository Services { get; set; }
        public IOrderRepository Orders { get; set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Baskets = new BasketRepository(_context);
            //Products = new ProductsRepository(_context);
            //Services = new ServicesRepository(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}
