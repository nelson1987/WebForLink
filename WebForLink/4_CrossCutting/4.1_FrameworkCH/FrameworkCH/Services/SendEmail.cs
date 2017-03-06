using FrameworkCH.Interfaces;
using System;
using System.Net;
using System.Net.Mail;

namespace FrameworkCH.Services
{
    public class SendEmail : ISendEmail
    {
        public void EnviarEmail(IEmail message)
        {
            if (message.Destinatarios.Count == 0)
                throw new Exception("Não há destinatários no email");

            var client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "mail.chconsultoria.com.br";
            client.Credentials = new NetworkCredential("webforlink@chconsultoria.com.br",
                "ch123456");
            for (int i = 0; i < message.Destinatarios.Count; i++)
            {
                var mail = new MailMessage("webforlink@chconsultoria.com.br",
                    message.Destinatarios[i],
                    message.Assunto,
                    message.Mensagem);
                client.Send(mail);
            }
        }
    }
}
