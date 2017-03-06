using System;
using System.Collections.Generic;
using FrameworkCH.Interfaces;

namespace FrameworkCH.Entities
{
    public class Email : IEmail
    {
        public string Assunto { get; set; }
        public List<string> Destinatarios { get; set; }
        public string Mensagem { get; set; }
        public string Remetente { get; set; }
    }
}
