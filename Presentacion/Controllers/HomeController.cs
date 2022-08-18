using Microsoft.AspNetCore.Mvc;
using Presentacion.Models;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using RegistroLogin.Filters;
using RegistroLogin.Models;
using RegistroLogin.Repositories;


namespace Presentacion.Controllers
{
    public class HomeController : Controller
    {
        private RepositoryWeb repo;

        public HomeController(RepositoryWeb repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(string email, string password, string nombre, string apellidos, string tipo)
        {
            bool registrado = this.repo.RegistrarUsuario(email, password, nombre, apellidos, tipo);
            if (registrado)
            {
                ViewData["MENSAJE"] = "Usuario registrado con exito";
            }
            else
            {
                ViewData["MENSAJE"] = "Error al registrar el usuario";
            }
            return View();
        }

        [AuthorizeUsers]
        public IActionResult PaginaProtegida()
        {
            return View();
        }

        [AuthorizeUsers(Policy = "ADMINISTRADORES")]
        public IActionResult AdminUsuarios()
        {
            List<Usuario> usuarios = this.repo.GetUsuarios();
            return View(usuarios);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}