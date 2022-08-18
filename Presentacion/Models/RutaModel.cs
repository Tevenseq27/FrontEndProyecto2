using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Models
{
    public class RutaModel
    {
        #region Propiedades

        public int IdRuta { get; set; }
        public string TerminalSalida { get; set; }
        public string TerminalLlegada { get; set; }
        public int CantidadParadas { get; set; }
        public int MontoEstimadoRuta { get; set; }

        #endregion

        #region Constructor

        public RutaModel()
        {
            IdRuta = 0;
            TerminalSalida = string.Empty;
            TerminalLlegada = string.Empty;
            CantidadParadas = 0;
            MontoEstimadoRuta = 0;
        }
        #endregion
    }
}
