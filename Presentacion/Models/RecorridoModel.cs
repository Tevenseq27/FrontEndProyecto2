using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Models
{
    public class RecorridoModel
    {
        #region Propiedades

        public int Id { get; set; }
        public int IdRutaAsignada { get; set; }
        public string PlacaUnidadAsignada { get; set; }
        public string IdChoferAsignado { get; set; }
        public string Estado { get; set; }
        public int? MontoRecibido { get; set; }

        #endregion

        #region Constructor

        public RecorridoModel()
        {
            Id = 0;
            IdRutaAsignada = 0;
            PlacaUnidadAsignada = string.Empty;
            IdChoferAsignado = string.Empty;
            Estado = string.Empty;
            MontoRecibido = 0;
        }
        #endregion
    }
}
