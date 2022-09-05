namespace SmallEshopAssignment.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IBasketRepository Baskets { get; }
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        Task<int> Save();
    }
}
