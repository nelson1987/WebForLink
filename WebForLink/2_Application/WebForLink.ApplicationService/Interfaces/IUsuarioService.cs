using System.Linq;
using WebForLink.Domain.Entities;

namespace WebForLink.ApplicationService.Interfaces
{
    public interface IUsuarioAppService
    {
        IQueryable<Usuario> Pesquisar(int idContratante);
    }
}
