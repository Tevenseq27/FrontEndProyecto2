using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Presentacion.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Presentacion.Controllers
{
    public class GestorConexiones : Controller
    {
        #region Propiedad

        public HttpClient Cliente { get; set; }

        #endregion

        #region Constructor 

        private void GestorDeConexiones()
        {
            Cliente = new HttpClient();
            Cliente.BaseAddress = new Uri("http://localhost:13985/");
            Cliente.DefaultRequestHeaders.Accept.Clear();
            Cliente.DefaultRequestHeaders.Accept.Add
                (
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
        }

        //Métodos
        #region BUS
        public async Task<List<BusModel>> ListarBus(BusModel P_Modelo)
        {
            List<BusModel> lstresultados = new List<BusModel>();
            GestorDeConexiones();
            string url = "api/Proyecto2/ConsultarBus";
            HttpResponseMessage resultado = await Cliente.GetAsync(url);

            if (resultado.IsSuccessStatusCode)
            {
                var convertirAstring = await resultado.Content.ReadAsStringAsync();
                lstresultados = JsonConvert.DeserializeObject<List<BusModel>>(convertirAstring);
            }

            return lstresultados;
        }

        public async Task<bool> AgregarBus(BusModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/AgregarBus";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarBus(BusModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/EliminarBus";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> ModificarBus(BusModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/ModificarBus";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }
        #endregion

        #region CHOFER

        //MÉTODO PARA LISTAR CHOFER EN DB
        public async Task<List<ChoferModel>> ListarChofer(ChoferModel P_Entidad)
        {
            List<ChoferModel> lstresultados = new List<ChoferModel>();
            GestorDeConexiones();
            string url = "api/Proyecto2/ConsultarChofer";
            HttpResponseMessage resultado = await Cliente.GetAsync(url);

            if(resultado.IsSuccessStatusCode)
            {
              var convertirAstring = await resultado.Content.ReadAsStringAsync();
              lstresultados = JsonConvert.DeserializeObject<List<ChoferModel>>(convertirAstring);
            }

            return lstresultados;
        }

        //MÉTODO PARA AGREGAR CHOFER EN DB
        public async Task<bool> AgregarChofer(ChoferModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/AgregarChofer";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        //MÉTODO PARA ELIMINAR CHOFER EN DB
        public async Task<bool> EliminarChofer(ChoferModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/EliminarChofer";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        //MÉTODO PARA MODIFICAR CHOFER EN DB
        public async Task<bool> ModificarChofer(ChoferModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/ModificarChofer";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }
        #endregion

        #region PERFIL
        public async Task<List<PerfilModel>> ListarPerfil(PerfilModel P_Entidad)
        {
            List<PerfilModel> lstresultados = new List<PerfilModel>();
            GestorDeConexiones();
            string url = "api/Proyecto2/ConsultarPerfil";
            HttpResponseMessage resultado = await Cliente.GetAsync(url);

            if (resultado.IsSuccessStatusCode)
            {
                var jsonSTRING = await resultado.Content.ReadAsStringAsync();
                lstresultados = JsonConvert.DeserializeObject<List<PerfilModel>>(jsonSTRING);
            }

            return lstresultados;
        }

        public async Task<bool> AgregarPerfil(PerfilModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/AgregarPerfil";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarPerfil(PerfilModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/EliminarPerfil";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> ModificarPerfil(PerfilModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/ModificarPerfil";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }
        #endregion

        #region RUTA
        public async Task<List<RutaModel>> ListarRuta(RutaModel P_Entidad)
        {
            List<RutaModel> lstresultados = new List<RutaModel>();
            GestorDeConexiones();
            string url = "api/Proyecto2/ConsultarRuta";
            HttpResponseMessage resultado = await Cliente.GetAsync(url);

            if (resultado.IsSuccessStatusCode)
            {
                var jsonSTRING = await resultado.Content.ReadAsStringAsync();
                lstresultados = JsonConvert.DeserializeObject<List<RutaModel>>(jsonSTRING);
            }

            return lstresultados;
        }

        public async Task<bool> AgregarRuta(RutaModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/AgregarRuta";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarRuta(RutaModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/EliminarRuta";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> ModificarRuta(RutaModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/ModificarRuta";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }
        #endregion

        #region RECORRIDO
        public async Task<List<RecorridoModel>> ListarRecorrido(RecorridoModel P_Entidad)
        {
            List<RecorridoModel> lstresultados = new List<RecorridoModel>();
            GestorDeConexiones();
            string url = "api/Proyecto2/ConsultarRecorrido";
            HttpResponseMessage resultado = await Cliente.GetAsync(url);

            if (resultado.IsSuccessStatusCode)
            {
                var jsonSTRING = await resultado.Content.ReadAsStringAsync();
                lstresultados = JsonConvert.DeserializeObject<List<RecorridoModel>>(jsonSTRING);
            }

            return lstresultados;
        }

        public async Task<bool> AgregarRecorrido(RecorridoModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/AgregarRecorrido";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarRecorrido(RecorridoModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/EliminarRecorrido";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> ModificarRecorrido(RecorridoModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/ModificarRecorrido";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }
        #endregion

        #endregion
    }
}
