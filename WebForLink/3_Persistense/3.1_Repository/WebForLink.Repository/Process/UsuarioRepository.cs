using WebForLink.Data;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Interfaces.Repository;
using WebForLink.Repository.Common;

namespace WebForLink.Repository.Process
{
    public class UsuarioRepository : RepositoryBase<Usuario, WebForLinkContexto>, IUsuarioRepository
    {
        //public List<Papel> ListarPorContratanteId(int contratanteId)
        //{
        //    return DbSet.Where(x => x.CONTRATANTE_ID == contratanteId).ToList();
        //}

        //public Papel BuscarPorContratanteIdETipoPapelId(int contratanteId, int tipoPapelId)
        //{
        //    return DbSet.FirstOrDefault(x => x.CONTRATANTE_ID == contratanteId && x.PAPEL_TP_ID == tipoPapelId);
        //}
    }

}
