using WebForLink.Domain.Entities.Validations;
using WebForLink.Domain.Interfaces.Validation;
using WebForLink.Domain.Validation;

namespace WebForLink.Domain.Entities
{
    public class Usuario : ISelfValidation
    {
        protected Usuario()
        {
        }

        public Usuario(string login)
        {
            Login = login;
        }
        public int Id { get; private set; }

        public string Login { get; private set; }

        public string Senha { get; private set; }

        public void SetLogin(string login)
        {
            Login = login;
        }

        public void SetSenha(string senha)
        {
            Senha = senha;
        }

        public bool EhValido
        {
            get
            {

                var validacaoExterna = new UsuarioValidacao();
                ValidationResult = validacaoExterna.Validar(this);
                return ValidationResult.EstaValidado;
            }
        }

        public ValidationResult ValidationResult { get; private set; }

    }
}
