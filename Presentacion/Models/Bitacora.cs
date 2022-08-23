using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Models
{
    public class Bitacora
    {
        #region Propiedades
        public string id { get; set; }
        public string IdUsuario { get; set; }
        public string descripcion { get; set; }
        #endregion

        #region Constructor
        public Bitacora()
        {
            id = string.Empty;
            IdUsuario = string.Empty;
            descripcion = string.Empty;
        }
        #endregion
    }
}