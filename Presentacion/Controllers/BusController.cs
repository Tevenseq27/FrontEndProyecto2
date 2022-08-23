using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Presentacion.Models;
using RegistroLogin.Data;
using RegistroLogin.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Controllers
{
    public class BusController : Controller
    {

        public async Task<IActionResult> Index()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<BusModel> lstresultados = await objconexion.ListarBus(new BusModel { PlacaUnidad = string.Empty });
            return View(lstresultados);
        }

        public IActionResult CrearBus()
        {
            return View();
        }

        public async Task<IActionResult> EditaBus(BusModel datos)
         {
            string id = datos.PlacaUnidad;

             GestorConexiones objconexion = new GestorConexiones();
             List<BusModel> lstresultados = await objconexion.ListarBus(new BusModel { PlacaUnidad = id });
             BusModel bus = lstresultados.Find(x => x.PlacaUnidad.Equals(id));
            RegistroBitacora(" modificó el detalles de la unidad.");
            return View(bus);

         }

      
        public async Task<IActionResult> Eliminar(BusModel b)
        {
            string Placa = b.PlacaUnidad;
            GestorConexiones objconexion = new GestorConexiones();
            List<BusModel> lstresultados = await objconexion.ListarBus(new BusModel { PlacaUnidad = string.Empty });
            BusModel cliente = lstresultados.Find(x => x.PlacaUnidad.Equals(Placa));

            return View(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Guardar(BusModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.AgregarBus(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Modificar(BusModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.ModificarBus(P_Modelo);
            RegistroBitacora(" modificó el detalles del bus placa " + P_Modelo.PlacaUnidad);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar_Bus(BusModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.EliminarBus(P_Modelo);
            return RedirectToAction("Index");
        }

        #region Bitacora


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
