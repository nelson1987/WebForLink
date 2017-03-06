using System.Web;
using WebForLink.Data.Interfaces;

namespace WebForLink.Data.Config
{
    public class ContextManager<TContext> : IContextManager<TContext>
        where TContext : IDbContext, new()
    {
        private readonly string _contextKey;

        public ContextManager()
        {
            _contextKey = "ContextKey." + typeof(TContext).Name;
        }

        public IDbContext GetContext()
        {
            if (HttpContext.Current.Items[_contextKey] == null)
                HttpContext.Current.Items[_contextKey] = new TContext();
            return HttpContext.Current.Items[_contextKey] as IDbContext;
        }

        public void Finish()
        {
            if (HttpContext.Current.Items[_contextKey] != null)
                ((IDbContext)HttpContext.Current.Items[_contextKey]).Dispose();
        }
    }
}
