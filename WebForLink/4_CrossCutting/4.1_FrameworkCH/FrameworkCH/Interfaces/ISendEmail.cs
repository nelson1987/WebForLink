using FrameworkCH.Entities;

namespace FrameworkCH.Interfaces
{
    /// <summary>
    /// Envio de e-mail CH
    /// </summary>
    public interface ISendEmail
    {
        void EnviarEmail(IEmail message);
    }
}
