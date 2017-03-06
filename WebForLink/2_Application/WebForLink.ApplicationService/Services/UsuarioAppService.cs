using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WebForLink.ApplicationService.Interfaces;
using WebForLink.ApplicationService.Services.Common;
using WebForLink.Data;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Interfaces.Services;

namespace WebForLink.ApplicationService.Services
{
    public class UsuarioAppService : AppService<WebForLinkContexto>, IUsuarioAppService
    {
        private IUsuarioService _usuarioRepository;

        public UsuarioAppService(IUsuarioService usuarioService)
        {
            _usuarioRepository = usuarioService;
        }

        public IQueryable<Usuario> Pesquisar(int idContratante)
        {
            var repository = _usuarioRepository.Get(idContratante);
            throw new NotImplementedException();
        }

        public Usuario CriarFornecedorIndividual(Usuario usuario)
        {
            _usuarioRepository.Add(usuario);
            return usuario;
        }

        public Usuario CriarFornecedor(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario CriarAncora(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void AlterarSenha(Usuario usuario, string senha)
        {
            //usuario.SetSenha(senha);
            //_usuarioRepository.Update(usuario);
            throw new NotImplementedException();
        }

        public void AlterarLogin(Usuario usuario, string login)
        {
            //usuario.SetLogin(login);
            //_usuarioRepository.Update(usuario);
            throw new NotImplementedException();
        }

        public ValidationResult CriarSolicitado(Usuario solicitado)
        {
            throw new NotImplementedException();
        }

    }
}
