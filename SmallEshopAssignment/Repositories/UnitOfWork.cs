using SmallEshopAssignment.IRepositories;
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
        public ICustomerRepository Customers { get; set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Baskets = new BasketRepository(_context);
            Products = new ProductRepository(_context);
            Services = new ServiceRepository(_context);
            Orders = new OrderRepository(_context);
            Customers = new CustomerRepository(_context);
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
