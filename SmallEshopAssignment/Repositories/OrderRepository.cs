using SmallEshopAssignment.IRepositories;
using SmallEshopAssignment.Model;

namespace SmallEshopAssignment.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context)
           : base(context)
        {

        }
    }
}
