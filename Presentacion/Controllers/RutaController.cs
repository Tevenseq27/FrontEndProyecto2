using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Presentacion.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Controllers
{
    public class RutaController : Controller
    {
        public async Task<IActionResult> Index()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<RutaModel> lstresultados = await objconexion.ListarRuta(new RutaModel { IdRuta = 0 });
            return View(lstresultados);
        }

        public IActionResult CrearRuta()
        {
            return View();
        }

        public async Task<IActionResult> EditaRuta(RutaModel datos)
         {
            int id = datos.IdRuta;

             GestorConexiones objconexion = new GestorConexiones();
             List<RutaModel> lstresultados = await objconexion.ListarRuta(new RutaModel { IdRuta = id });
             RutaModel ruta = lstresultados.Find(x => x.IdRuta.Equals(id));

             return View(ruta);
        
         }

      
        public async Task<IActionResult> Eliminar(RutaModel r)
        {
            int id = r.IdRuta;
            GestorConexiones objconexion = new GestorConexiones();
            List<RutaModel> lstresultados = await objconexion.ListarRuta(new RutaModel { IdRuta = 0 });
            RutaModel ruta = lstresultados.Find(x => x.IdRuta.Equals(id));

            return View(ruta);
        }

        [HttpPost]
        public async Task<IActionResult> Guardar(RutaModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.AgregarRuta(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Modificar(RutaModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.ModificarRuta(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar_Ruta(RutaModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.EliminarRuta(P_Modelo);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Consulta()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<RutaModel> lstresultados = await objconexion.ListarRuta(new RutaModel { IdRuta = 0 });
            return View(lstresultados);
        }

    }
}
