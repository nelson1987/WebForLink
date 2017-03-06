using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebForLink.Data.Mapper;
using WebForLink.Domain.Entities;

namespace WebForLink.Data
{
    public class WebForLinkContexto : DbContext
    {
        static WebForLinkContexto()
        {
            Database.SetInitializer<WebForLinkContexto>(null);
        }

        public WebForLinkContexto() : base("Name=WebForLinkContexto") 
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Pluraliza de Tabelas
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //Deletar em cascata
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>(); //Deletar em cascata

            modelBuilder.Properties()
                .Where(p => p.Name.Equals("Id"))
                .Configure(p => p.IsKey());
            modelBuilder.Properties()
                .Where(p => p.Name.Equals("Id"))
                .Configure(x => x.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar")
                    .HasMaxLength(255));
            
            modelBuilder.Configurations.Add(new UsuarioMapper());
        }
    }
}
