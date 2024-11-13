using Microsoft.AspNetCore.Mvc;
using PROJETO_INTERCISCIPLINAR.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace PROJETO_INTERCISCIPLINAR.Controllers
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
            // Verifica se o usuário está logado (se existe o "UserName" na sessão)
            ViewBag.IsLoggedIn = !string.IsNullOrEmpty(HttpContext.Session.GetString("UserNome"));
            return View();
        }

        public IActionResult autismo()
        {
            return View();
        }

        public IActionResult leisedireitos()
        {
            return View();
        }

        public IActionResult eventos()
        {
            return View();
        }

        public IActionResult tratamentos()
        {
            return View();
        }

        public IActionResult sobrenos()
        {
            return View();
        }

        public IActionResult contato()
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }

        public IActionResult Perfil()
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
