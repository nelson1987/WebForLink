using FrameworkCH.Interfaces;
using System.Collections.Generic;

namespace FrameworkCH.Entities
{
    public class Email : IEmail
    {
        public string Assunto { get; private set; }
        public List<string> Destinatarios { get; private set; }
        public string Mensagem { get; private set; }

        public Email()
        {
            Destinatarios = new List<string>();
        }
        public void SetAssunto(string assunto)
        {
            Assunto = assunto;
        }

        public void SetDestinatarios(params string[] destinatarios)
        {
            Destinatarios.AddRange(destinatarios);
        }

        public void SetMensagem(string mensagem)
        {
            Mensagem = mensagem;
        }
    }
}
