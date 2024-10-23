using Ejercicio04.Models;
using Ejercicio04.Models.DAL;
using Ejercicio04.Models.ENT;
using Ejercicio04.Models.VM;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio04.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult VistaPersonas()
        {
            ClsPersona persona = ClsListado.sacarPersonasRandom();

            return View(persona);
        }

        public IActionResult EditarPersona()
        {

            var persona = ClsListado.sacarPersonasRandom(); 
   
            var model = new ClsEditarPersonaVM(persona) 
            {
                Departamentos = ClsListado.ListadoDepartamentos() 
            };

            return View(model); 
        }

        public IActionResult ListaDepartamentos()
        {
            ViewBag.Departamentos = ClsListado.ListadoDepartamentos();
            return View();
        }

        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
