using System.Web.Mvc;
using WebForLink.ApplicationService.Interfaces;
using WebForLink.Domain.Entities;

namespace WebForLink.Web.Areas.Administrador.Controllers
{
    [AllowAnonymous]
    public class UsuarioController : Controller
    {
        private IUsuarioAppService _ContratantefornecedorService { get; set; }

        public UsuarioController(IUsuarioAppService service)
        {
            _ContratantefornecedorService = service;
        }

        // GET: Administrador/Usuario
        public ActionResult Index()
        {
            var nelson = new Usuario("nelson.neto");
            _ContratantefornecedorService.CriarFornecedorIndividual(nelson);
            //var usuario = _ContratantefornecedorService.Buscar(1);
            return View();
        }
    }
}