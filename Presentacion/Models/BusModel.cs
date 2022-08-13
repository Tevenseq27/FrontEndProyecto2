using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Models
{
    public class BusModel
    {
        #region Propiedades

        public string PlacaUnidad { get; set; }
        public int NumeroUnidad { get; set; }
        public string EstadoUnidad { get; set; }

        #endregion

        #region Constructor

        public BusModel()
        {
            PlacaUnidad = string.Empty;
            NumeroUnidad = 0;
            EstadoUnidad = string.Empty;
        }
        #endregion
    }
}
