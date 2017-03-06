using System.Collections.Generic;

namespace FrameworkCH.Interfaces
{
    public interface IEmail
    {
        string Remetente { get; set; }
        List<string> Destinatarios { get; set; }
        string Mensagem { get; set; }
        string Assunto { get; set; }
    }
}
