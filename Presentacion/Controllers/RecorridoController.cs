using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Presentacion.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Controllers
{
    public class RecorridoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<RecorridoModel> lstresultados = await objconexion.ListarRecorrido(new RecorridoModel { Id = 0 });
            return View(lstresultados);
        }

        public IActionResult CrearRecorrido()
        {
            return View();
        }

        public async Task<IActionResult> EditaRecorrido(RecorridoModel datos)
         {
            int id = datos.Id;

             GestorConexiones objconexion = new GestorConexiones();
             List<RecorridoModel> lstresultados = await objconexion.ListarRecorrido(new RecorridoModel { Id = id });
             RecorridoModel recorrido = lstresultados.Find(x => x.Id.Equals(id));

             return View(recorrido);
         }

      
        public async Task<IActionResult> Eliminar(RecorridoModel r)
        {
            int id = r.Id;
            GestorConexiones objconexion = new GestorConexiones();
            List<RecorridoModel> lstresultados = await objconexion.ListarRecorrido(new RecorridoModel { Id = 0 });
            RecorridoModel recorrido = lstresultados.Find(x => x.Id.Equals(id));

            return View(recorrido);
        }

        [HttpPost]
        public async Task<IActionResult> Guardar(RecorridoModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.AgregarRecorrido(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Modificar(RecorridoModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.ModificarRecorrido(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar_Recorrido(RecorridoModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.EliminarRecorrido(P_Modelo);
            return RedirectToAction("Index");
        }

    }
}
