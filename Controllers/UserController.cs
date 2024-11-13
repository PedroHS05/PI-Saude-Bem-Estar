using System.Linq;
using LoginCadastroMVC.Data;
using LoginCadastroMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginCadastroMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        // Exibe a página de login e cadastro
        public IActionResult Login()
        {
            return View("/Views/Home/login.cshtml");
        }

        public IActionResult Logout()
        {
            // Remove a sessão do nome do usuário
            HttpContext.Session.Remove("UserNome");
            // Redireciona para a página inicial
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Este e-mail já está em uso.");
                    return View("/Views/Home/login.cshtml", user);
                }

                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View("/Views/Home/login.cshtml", user); // Retorna a view com os erros de validação
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Senha == senha);
            if (user != null)
            {
                HttpContext.Session.SetString("UserNome", user.Nome);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ErrorMessage = "Credenciais inválidas";
            return View("/Views/Home/login.cshtml");
        }
    }
}