using Microsoft.AspNetCore.Mvc;
using Presentacion.Models;
using System.Collections.Generic;
using System.Linq;
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
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar_Chofer(ChoferModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.EliminarChofer(P_Modelo);
            return RedirectToAction("Index");
        }


    }
}
