using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Presentacion.Models;
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
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar_Bus(BusModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.EliminarBus(P_Modelo);
            return RedirectToAction("Index");
        }

    }
}
