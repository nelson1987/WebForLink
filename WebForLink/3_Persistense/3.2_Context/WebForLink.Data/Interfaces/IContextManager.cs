namespace WebForLink.Data.Interfaces
{
    public interface IContextManager<TContext>
        where TContext : IDbContext, new()
    {
        IDbContext GetContext();
        void Finish();
    }
}
