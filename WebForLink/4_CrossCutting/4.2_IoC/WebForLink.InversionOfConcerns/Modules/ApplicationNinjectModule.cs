using Ninject.Modules;
using WebForLink.ApplicationService.Interfaces;
using WebForLink.ApplicationService.Services;
using WebForLink.ApplicationService.Services.Common;

namespace WebForLink.CrossCutting.InversionControl.Modules
{
    public class ApplicationServiceNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppService<>)).To(typeof(AppService<>));

            Bind<IUsuarioAppService>().To<UsuarioAppService>();
        }
    }
}