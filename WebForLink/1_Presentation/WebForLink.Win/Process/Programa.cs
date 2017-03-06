using FrameworkCH.Entities;
using FrameworkCH.Interfaces;
using FrameworkCH.Services;
using WebForLink.ApplicationService.Interfaces;
using WebForLink.ApplicationService.Services;

namespace WebForLink.Win.Process
{
    public class Programa
    {
        private IUsuarioAppService _appService;
        private IEmail _email;
        private ISendEmail _envioEmail;
        public Programa()
        {
            _appService = new UsuarioAppService();
            _email = new Email();
            _envioEmail = new SendEmail();
        }
        public void CriarListaDeUsuarios()
        {
            var pesquisa = _appService.Pesquisar(1);
        }
        public void EnviarEmails()
        {
            _email.SetDestinatarios("nelson.neto@chconsultoria.com.br","carlos.jesus@chconsultoria.com.br");
            _email.SetAssunto("Teste");
            _email.SetMensagem("Isso é uma mensagem teste");
            _envioEmail.EnviarEmail(_email);
        }
    }
}
