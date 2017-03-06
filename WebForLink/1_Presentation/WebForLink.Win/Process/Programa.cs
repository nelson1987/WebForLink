using FrameworkCH.Interfaces;
using Ninject;
using System.Linq;
using WebForLink.ApplicationService.Interfaces;
using WebForLink.ApplicationService.Services;
using WebForLink.Domain.Entities;
using WebForLink.InversionOfConcerns;

namespace WebForLink.Win.Process
{
    public class Programa
    {
        private IUsuarioAppService _appService;
        private IEmail _email;
        private ISendEmail _envioEmail;
        public Programa(IUsuarioAppService appService)
        {
            //_email = new Email();
            //_envioEmail = new SendEmail();
        }
        public Programa()
        {
            IoC ioc = new IoC();
            IKernel kernel = ioc.Kernel;
            _appService = kernel.Get<IUsuarioAppService>();//.To<UsuarioAppService>();

        }
        public void CriarListaDeUsuarios()
        {
            var user = new Usuario("nelson.neto");
            _appService.BeginTransaction();
            var inclusaoUsuario = _appService.CriarFornecedorIndividual(user);
            //servico.AlterarSenha(user, "1234");
            _appService.Commit();

            _appService.BeginTransaction();
            _appService.AlterarSenha(user, "2345");
            _appService.Commit();
        }
        public void EnviarEmails()
        {
            _email.SetDestinatarios("nelson.neto@chconsultoria.com.br", "carlos.jesus@chconsultoria.com.br");
            _email.SetAssunto("Teste");
            _email.SetMensagem("Isso é uma mensagem teste :*");
            _envioEmail.EnviarEmail(_email);
        }
    }
}
