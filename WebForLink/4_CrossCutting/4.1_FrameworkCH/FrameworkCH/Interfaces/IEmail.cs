using System.Collections.Generic;

namespace FrameworkCH.Interfaces
{
    public interface IEmail
    {
        List<string> Destinatarios { get; }
        string Mensagem { get; }
        string Assunto { get; }
        void SetDestinatarios(params string[] destinatarios);
        void SetMensagem(string mensagem);
        void SetAssunto(string assunto);
    }
}
