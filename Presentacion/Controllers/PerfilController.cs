using Microsoft.AspNetCore.Mvc;
using Presentacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Controllers
{
    public class PerfilController : Controller
    {

        public async Task<IActionResult> Index()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<PerfilModel> lstresultados = await objconexion.ListarPerfil( new PerfilModel { CodigoPerfil = 0 } );

            return View(lstresultados);
        }

        public IActionResult CrearPerfil()
        {
            return View();
        }

        public async Task<IActionResult> EditaPerfil(PerfilModel perfil)
        {
            int id = perfil.CodigoPerfil;

            GestorConexiones objconexion = new GestorConexiones();
            List<PerfilModel> lstresultados = await objconexion.ListarPerfil(new PerfilModel { CodigoPerfil = id });
            PerfilModel objPerfil = lstresultados.Find(x => x.CodigoPerfil.Equals(perfil.CodigoPerfil));

            return View(objPerfil);
        }

        public async Task<IActionResult> Eliminar(PerfilModel perfil)
        {
            int Codigo = perfil.CodigoPerfil;

            GestorConexiones objconexion = new GestorConexiones();
            List<PerfilModel> lstresultados = await objconexion.ListarPerfil( new PerfilModel { CodigoPerfil = 0 } );
            PerfilModel objPerfil = lstresultados.Find(x => x.CodigoPerfil.Equals(Codigo));

            return View(objPerfil);
        }

        [HttpPost]
        public async Task<IActionResult> Guardar(PerfilModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.AgregarPerfil(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Modificar(PerfilModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.ModificarPerfil(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar_Perfil(PerfilModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.EliminarPerfil(P_Modelo);
            return RedirectToAction("Index");
        }


    }
}
