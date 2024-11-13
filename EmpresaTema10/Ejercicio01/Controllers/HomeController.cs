using Ejercicio01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace Ejercicio01.Controllers
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
            
            return View("Index");
        }
        [HttpPost]
        public IActionResult IndexConectado()
        {
            //abrir aqui la conexion con un trycatch y luego verificar si esta conectado
            string estado = "";
            SqlConnection miConexion = new SqlConnection();

            try

            {
                miConexion.ConnectionString = databaseDAL.CadenaConexion();
                miConexion.Open();

                estado = miConexion.State.ToString();
            }
            catch (Exception ex)
            {
                estado = "Hubo un problema";
            }
            finally
            {
                miConexion.Close();
            }

            ViewBag.estado = estado;
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
