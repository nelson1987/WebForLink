using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using WebForLink.Data.Config;
using WebForLink.Data.Mapper;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Validation;

namespace WebForLink.Data
{
    public class WebForLinkContexto : BaseDbContext
    {
        static WebForLinkContexto()
        {
            Database.SetInitializer<WebForLinkContexto>(null);
        }

        public WebForLinkContexto()
            : base("Name=WebForLinkContexto")
        {
            Database.SetInitializer<WebForLinkContexto>(null);
            Database.Log = sql => Debug.Write(sql);
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

            //modelBuilder.Properties()
            //    .Where(p => p.Name.Equals("ValidationResult"))
            //    .Configure(p => p.igno);
            //modelBuilder.Ignore()
            //Ignore(t => t.ValidationResult);
            //modelBuilder.Types().Configure(c => c.Ignore("IsDeleted"));
            modelBuilder.Ignore<ValidationResult>();

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
