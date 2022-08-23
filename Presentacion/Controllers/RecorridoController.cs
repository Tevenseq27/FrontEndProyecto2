using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Presentacion.Models;
using System;
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

        public async Task<IActionResult> CrearRecorridoAsync()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<RutaModel> lstRutas = await objconexion.ListarRuta(new RutaModel { IdRuta = 0 });
            List<BusModel> lstBuses = await objconexion.ListarBus(new BusModel { PlacaUnidad = string.Empty });
            List<ChoferModel> lstChoferes = await objconexion.ListarChofer(new ChoferModel { IdChofer = string.Empty });
            //string delimiter = ",";

            //RUTA
            List<SelectListItem> rutaList = lstRutas.ConvertAll(a =>
            {
                return new SelectListItem()
                {

                    Text = "Id Ruta: " + a.IdRuta.ToString() ,
                    Value = a.IdRuta.ToString(),

                    Selected = false
                };
            });

            //BUS
            List<SelectListItem> busList = lstBuses.ConvertAll(a =>
            {
                return new SelectListItem()
                {

                    Text = "Placa: " + a.PlacaUnidad.ToString(),
                    Value = a.PlacaUnidad.ToString(),

                    Selected = false
                };
            });

            //CHOFER
            List<SelectListItem> choferList = lstChoferes.ConvertAll(a =>
            {
                return new SelectListItem()
                {

                    Text = "Id Chofer: " + a.IdChofer.ToString(),
                    Value = a.IdChofer.ToString(),

                    Selected = false
                };
            });

            ViewBag.Rutas = rutaList;
            ViewBag.Buses = busList;
            ViewBag.Choferes = choferList;

            return View();
        }

        public async Task<IActionResult> EditaRecorrido(RecorridoModel datos)
         {
            int id = datos.Id;

            GestorConexiones objconexion = new GestorConexiones();
            List<RecorridoModel> lstresultados = await objconexion.ListarRecorrido(new RecorridoModel { Id = id });
            RecorridoModel recorrido = lstresultados.Find(x => x.Id.Equals(id));

            List<RutaModel> lstRutas = await objconexion.ListarRuta(new RutaModel { IdRuta = 0 });
            List<BusModel> lstBuses = await objconexion.ListarBus(new BusModel { PlacaUnidad = string.Empty });
            List<ChoferModel> lstChoferes = await objconexion.ListarChofer(new ChoferModel { IdChofer = string.Empty });
            //string delimiter = ",";

            //RUTA
            List<SelectListItem> rutaList = lstRutas.ConvertAll(a =>
            {
                return new SelectListItem()
                {

                    Text = "Id Ruta: " + a.IdRuta.ToString(),
                    Value = a.IdRuta.ToString(),

                    Selected = false
                };
            });

            //BUS
            List<SelectListItem> busList = lstBuses.ConvertAll(a =>
            {
                return new SelectListItem()
                {

                    Text = "Placa: " + a.PlacaUnidad.ToString(),
                    Value = a.PlacaUnidad.ToString(),

                    Selected = false
                };
            });

            //CHOFER
            List<SelectListItem> choferList = lstChoferes.ConvertAll(a =>
            {
                return new SelectListItem()
                {

                    Text = "Id Chofer: " + a.IdChofer.ToString(),
                    Value = a.IdChofer.ToString(),

                    Selected = false
                };
            });

            ViewBag.Rutas = rutaList;
            ViewBag.Buses = busList;
            ViewBag.Choferes = choferList;

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

            string idRutatxt = Request.Form["Ruta"].ToString();
            string placatxt = Request.Form["Bus"].ToString();
            string idChofertxt = Request.Form["Chofer"].ToString();

            P_Modelo.IdRutaAsignada = Convert.ToInt32(idRutatxt);
            P_Modelo.PlacaUnidadAsignada = placatxt;
            P_Modelo.IdChoferAsignado = idChofertxt;

            await objconexion.AgregarRecorrido(P_Modelo);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Modificar(RecorridoModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();

            string idRutatxt = Request.Form["Ruta"].ToString();
            string placatxt = Request.Form["Bus"].ToString();
            string idChofertxt = Request.Form["Chofer"].ToString();

            P_Modelo.IdRutaAsignada = Convert.ToInt32(idRutatxt);
            P_Modelo.PlacaUnidadAsignada = placatxt;
            P_Modelo.IdChoferAsignado = idChofertxt;

            await objconexion.ModificarRecorrido(P_Modelo);
            RegistroBitacora(" modificó el detalles del recorrido id " + P_Modelo.Id + " Chofer: " + P_Modelo.IdChoferAsignado + " Bus: " + P_Modelo.Bus);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar_Recorrido(RecorridoModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.EliminarRecorrido(P_Modelo);
            return RedirectToAction("Index");
        }

        public async void RegistroBitacora(string desc)
        {
            Bitacora registro = new Bitacora();
            GestorConexiones objConexion = new GestorConexiones();
            registro.IdUsuario = GestorConexiones.ClaseCompartida.idUsuario;
            registro.descripcion = "El usuario " + registro.IdUsuario + desc;
            registro.IdUsuario = GestorConexiones.ClaseCompartida.idUsuario;
            await objConexion.AgregarBitacora(registro);
        }

    }
}
