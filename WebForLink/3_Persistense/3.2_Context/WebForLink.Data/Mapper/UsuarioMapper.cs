using System.Data.Entity.ModelConfiguration;
using WebForLink.Domain.Entities;

namespace WebForLink.Data.Mapper
{
    public class UsuarioMapper : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapper()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Login)
                .IsRequired();

            Ignore(t => t.ValidationResult);

            // Table & Column Mappings
            ToTable("WFL_USUARIO");
            Property(t => t.Id).HasColumnName("ID_USUARIO");
            Property(t => t.Login).HasColumnName("LOGIN");
        }
    }
}
