﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WebForLink.ApplicationService.Common;
using WebForLink.ApplicationService.Interfaces;
using WebForLink.Data;
using WebForLink.Domain.Entities;
using WebForLink.Repository.Interfaces;
using WebForLink.Repository.Process;

namespace WebForLink.ApplicationService.Services
{
    public class UsuarioAppService : AppService<WebForLinkContexto>, IUsuarioAppService
    {
        private IUsuarioRepository _usuarioRepository;        

        public UsuarioAppService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public UsuarioAppService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public IQueryable<Usuario> Pesquisar(int idContratante)
        {
            return _usuarioRepository.Select();
        }

        public Usuario CriarFornecedorIndividual(Usuario usuario)
        {
            _usuarioRepository.Insert(usuario);
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
            usuario.SetSenha(senha);
            _usuarioRepository.Update(usuario);
        }

        public void AlterarLogin(Usuario usuario, string login)
        {
            usuario.SetLogin(login);
            _usuarioRepository.Update(usuario);
        }

        public ValidationResult CriarSolicitado(Usuario solicitado)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
