using Ninject.Modules;
using WebForLink.Domain.Interfaces.Services;
using WebForLink.Domain.Interfaces.Services.Common;
using WebForLink.Domain.Services;
using WebForLink.Domain.Services.Common;

namespace WebForLink.CrossCutting.InversionControl.Modules
{
    public class ServiceNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IService<>)).To(typeof(Service<>));

            Bind<IUsuarioService>().To<UsuarioService>();
        }
    }
}