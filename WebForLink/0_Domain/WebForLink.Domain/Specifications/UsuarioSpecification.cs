using WebForLink.Domain.Entities;
using WebForLink.Domain.Interfaces.Specification;

namespace WebForLink.Domain.Specifications
{
    public class UsuarioDeveTerLoginPreenchido : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario entity)
        {
            return !string.IsNullOrEmpty(entity.Login);
        }
    }
}
