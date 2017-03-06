using System;
using WebForLink.InversionOfConcerns;
using WebForLink.Win.Process;

namespace WebForLink.Win
{
    public class Program
    {
        static void Main()
        {
            Programa prog = new Programa();
            prog.CriarListaDeUsuarios();
            //prog.EnviarEmails();
        }
    }
}
