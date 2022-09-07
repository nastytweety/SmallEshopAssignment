using SmallEshopAssignment.IRepositories;
using SmallEshopAssignment.Model;

namespace SmallEshopAssignment.Repositories
{
    public class BasketRepository : Repository<Basket>,IBasketRepository
    {
        public BasketRepository(AppDbContext context)
            : base(context)
        {
            
        }

        public virtual void Add(Product product)
        {
            //check rules for adding
        }
    }
}
