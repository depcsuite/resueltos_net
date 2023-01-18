using Microsoft.AspNetCore.Mvc;

namespace TiendaLibros.Controllers
{
    public class TiendaLibrosController : Controller
    {
        public IActionResult Index()
        {
            //Envio de datos desde el controlador hacia la vista
            ViewBag.Titulo = "Tienda de libros";
            ViewBag.Mensaje = "La mejor tienda del Argentina!!";

            ViewData["Empresa"] = "Tienda Libros SA";
            ViewData["Desde"] = "Creada en 1990";



            return View();
        }

        public IActionResult Sale()
        {
            return View();
        }

    }
}
