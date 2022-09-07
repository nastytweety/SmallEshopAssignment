using SmallEshopAssignment.IRepositories;
using SmallEshopAssignment.Model;

namespace SmallEshopAssignment.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context)
           : base(context)
        {

        }
    }

}
