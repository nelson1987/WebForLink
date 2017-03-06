using Ninject.Modules;
using WebForLink.ApplicationService.Interfaces;
using WebForLink.ApplicationService.Services;
using WebForLink.ApplicationService.Services.Common;
using WebForLink.Data;

namespace WebForLink.CrossCutting.InversionControl.Modules
{
    public class ApplicationServiceNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppService<WebForLinkContexto>)).To(typeof(AppService<WebForLinkContexto>));

            Bind<IUsuarioAppService>().To<UsuarioAppService>();
        }
    }
}