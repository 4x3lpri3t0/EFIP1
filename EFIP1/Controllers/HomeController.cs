using EFIP1.Models;
using EFIP1.Services;
using System.Linq;
using System.Web.Mvc;

namespace EFIP1.Controllers
{
    public class HomeController : Controller
    {
        private readonly CalificacionesService calificacionesService;

        public HomeController()
        {
            this.calificacionesService = new CalificacionesService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Proveedores()
        {
            var model = this.calificacionesService.ObtenerProveedores();

            return View(model);
        }

        [HttpPost]
        public ActionResult PostCalificacion(Calificacion calificacion)
        {
            bool puntajeInvalido = (calificacion.Puntaje < 1 || calificacion.Puntaje > 5);

            if (string.IsNullOrWhiteSpace(calificacion.NombreProveedor) ||
                calificacion.NroOrdenCompra < 1 ||
                puntajeInvalido)
            {
                return View("Error");
            }

            this.calificacionesService.AgregarCalificacion(calificacion);

            return RedirectToAction("Index");
        }
    }
}