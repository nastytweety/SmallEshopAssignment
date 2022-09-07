using SmallEshopAssignment.IRepositories;
using SmallEshopAssignment.Model;

namespace SmallEshopAssignment.Repositories
{
    public class ServiceRepository : Repository<Service>,IServiceRepository
    {
        public ServiceRepository(AppDbContext context)
           : base(context)
        {

        }
    }
}
