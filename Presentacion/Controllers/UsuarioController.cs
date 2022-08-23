using Microsoft.AspNetCore.Mvc;
using Presentacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Controllers
{
    public class UsuarioController : Controller
    {

        public async Task<IActionResult> Index()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<UsuariosModel> lstresultados = await objconexion.ListarUsuario( new UsuariosModel { ID_USUARIO = 0 } );

            return View(lstresultados);
        }

        public IActionResult CrearUsuario()
        {
            return View();
        }


        public async Task<IActionResult> EditaUsuario(UsuariosModel user)
        {
            int id = user.ID_USUARIO;

            GestorConexiones objconexion = new GestorConexiones();
            List<UsuariosModel> lstresultados = await objconexion.ListarUsuario(new UsuariosModel { ID_USUARIO = id });
            UsuariosModel objUser = lstresultados.Find(x => x.ID_USUARIO.Equals(id));

            return View(objUser);
        }

        public async Task<IActionResult> Eliminar(UsuariosModel user)
        {
            int Codigo = user.ID_USUARIO;

            GestorConexiones objconexion = new GestorConexiones();
            List<UsuariosModel> lstresultados = await objconexion.ListarUsuario( new UsuariosModel { ID_USUARIO = 0 } );
            UsuariosModel objUser = lstresultados.Find(x => x.ID_USUARIO.Equals(Codigo));

            return View(objUser);
        }

        [HttpPost]
        public async Task<IActionResult> Guardar(UsuariosModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.AgregarUsuario(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Modificar(UsuariosModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.ModificarUsuario(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar_Usuario(UsuariosModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.EliminarUsuario(P_Modelo);
            return RedirectToAction("Index");
        }


    }
}
