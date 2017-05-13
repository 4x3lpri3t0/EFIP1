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

        [HttpPost]
        public string PostCalificacion(Calificacion calificacion)
        {
            if (calificacion.NroProveedor < 1 ||
                calificacion.NroOrdenCompra < 1 ||
                (calificacion.Puntaje < 1 || calificacion.Puntaje > 5))
            {
                return "Hi there!";
            }

            this.calificacionesService.AddCalificacion(calificacion);

            return "Hi there!";
        }
    }
}