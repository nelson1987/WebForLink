using WebForLink.Domain.Specifications;
using WebForLink.Domain.Validation;

namespace WebForLink.Domain.Entities.Validations
{
    public sealed class UsuarioValidacao : Validation<Usuario>
    {
        public UsuarioValidacao()
        {
            AddRule(new ValidationRule<Usuario>(new UsuarioDeveTerLoginPreenchido(), Resource.LoginObrigatorio));
        }
    }
}
