using System.Linq;
using WebForLink.Domain.Entities;

namespace WebForLink.ApplicationService.Interfaces
{
    public interface IUsuarioAppService
    {
        IQueryable<Usuario> Pesquisar(int idContratante);
        Usuario CriarFornecedorIndividual(Usuario usuario);
        Usuario CriarFornecedor(Usuario usuario);
        Usuario CriarAncora(Usuario usuario);
        void AlterarSenha(Usuario usuario, string senha);
        void AlterarLogin(Usuario usuario, string login);
    }
}
