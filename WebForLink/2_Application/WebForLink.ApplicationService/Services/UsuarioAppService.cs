using System;
using System.Linq;
using WebForLink.ApplicationService.Interfaces;
using WebForLink.Domain.Entities;

namespace WebForLink.ApplicationService.Services
{
    public class UsuarioAppService : IUsuarioAppService
    {
        public IQueryable<Usuario> Pesquisar(int idContratante)
        {
            throw new NotImplementedException();
        }
    }
}
