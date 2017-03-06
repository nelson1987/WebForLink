using WebForLink.Data.Interfaces;

namespace WebForLink.ApplicationService.Interfaces.Common
{
    public interface ITransactionAppService<TContext>
            where TContext : IDbContext, new()
    {
        void BeginTransaction();
        void Commit();
    }
}
