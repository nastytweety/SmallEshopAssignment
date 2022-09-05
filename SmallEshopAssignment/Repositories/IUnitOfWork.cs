namespace SmallEshopAssignment.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        //ITickerRepository Tickers { get; }
        //ISourceRepository Sources { get; }
        //ICurrencyrepository Currencies { get; }
        int Save();
    }
}
