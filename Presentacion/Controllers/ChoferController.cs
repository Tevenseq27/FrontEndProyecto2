using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Models;
using RegistroLogin.Models;
using RegistroLogin.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Presentacion.Controllers
{
    public class ChoferController : Controller
    {

        //--------LISTAR CHOFER--------
        public async Task<IActionResult> Index()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<ChoferModel> lstresultados = await objconexion.ListarChofer(new ChoferModel { IdChofer = string.Empty });
            return View(lstresultados);
        }

        //--------CREAR--------
        public IActionResult CrearChofer()
        {
            return View();
        }

        //--------MODIFICAR--------
        public async Task<IActionResult> EditaChofer(ChoferModel Chofer)
        {
            string id = ModelState.Values.Last().RawValue.ToString();
            GestorConexiones objconexion = new GestorConexiones();
            List<ChoferModel> lstresultados = await objconexion.ListarChofer(new ChoferModel { IdChofer = string.Empty });
            ChoferModel habitacion = lstresultados.Find(x => x.IdChofer.Equals(Chofer.IdChofer));

            return View(habitacion);
        }

        //--------ELIMINAR--------
        public async Task<IActionResult> Eliminar(ChoferModel Chofer)
        {

            GestorConexiones objconexion = new GestorConexiones();
            List<ChoferModel> lstresultados = await objconexion.ListarChofer(new ChoferModel { IdChofer = string.Empty });
            ChoferModel habitacion = lstresultados.Find(x => x.IdChofer.Equals(Chofer.IdChofer));

            return View(habitacion);
        }

        [HttpPost]
        public async Task<IActionResult> Guardar(ChoferModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.AgregarChofer(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Modificar(ChoferModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.ModificarChofer(P_Modelo);
            RegistroBitacora(" modificó el detalles del chofer: " + P_Modelo.Nombre1Chofer);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar_Chofer(ChoferModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.EliminarChofer(P_Modelo);
            return RedirectToAction("Index");
        }


        #region Bitácora

        public async void RegistroBitacora(string desc)
        {
            Bitacora registro = new Bitacora();
            GestorConexiones objConexion = new GestorConexiones();
            registro.descripcion = "El usuario " + GestorConexiones.ClaseCompartida.idUsuario + desc;
            registro.IdUsuario = GestorConexiones.ClaseCompartida.idUsuario;
            await objConexion.AgregarBitacora(registro);
        }

        #endregion
    }
}
