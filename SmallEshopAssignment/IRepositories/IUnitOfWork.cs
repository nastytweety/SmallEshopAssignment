using SmallEshopAssignment.IRepositories;

namespace SmallEshopAssignment.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IBasketRepository Baskets { get; }
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        IServiceRepository Services { get;  }
        ICustomerRepository Customers { get; }
        void Dispose();
        Task<int> Save();
    }
}
