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
            BeginTransaction();
            _usuarioRepository.Add(usuario);
            Commit();
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
            BeginTransaction();
            usuario.SetSenha(senha);
            _usuarioRepository.Update(usuario);
            Commit();
        }

        public void AlterarLogin(Usuario usuario, string login)
        {
            BeginTransaction();
            usuario.SetLogin(login);
            _usuarioRepository.Update(usuario);
            Commit();
        }

        public ValidationResult CriarSolicitado(Usuario solicitado)
        {
            throw new NotImplementedException();
        }

        public Usuario Buscar(int id)
        {
            return _usuarioRepository.Get(id);
        }
    }
}
