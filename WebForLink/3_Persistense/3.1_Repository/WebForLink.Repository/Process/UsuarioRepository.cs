using System;
using WebForLink.Data;
using WebForLink.Domain.Entities;
using WebForLink.Repository.Common;
using WebForLink.Repository.Interfaces;

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
