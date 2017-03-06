using Ninject.Modules;
using WebForLink.Domain.Interfaces.Repository;
using WebForLink.Domain.Interfaces.Repository.Common;
using WebForLink.Repository.Common;
using WebForLink.Repository.Process;

namespace WebForLink.CrossCutting.InversionControl.Modules
{
    public class RepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUsuarioRepository>().To<UsuarioRepository>();
        }
    }
}