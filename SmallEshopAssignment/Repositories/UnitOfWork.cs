using SmallEshopAssignment.Model;

namespace SmallEshopAssignment.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IBasketRepository Basket { get; set; }
        public IProductRepository Products { get; set; }
        public IServiceRepository Services { get; set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Basket = new BasketRepository(_context);
            //Sources = new SourceRepository(_context);
            //Currencies = new CurrencyRepository(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
