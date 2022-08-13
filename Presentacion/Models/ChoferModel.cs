using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Models
{
    public class ChoferModel
    {
        #region Propiedades
        public string IdChofer { get; set; }
        public string Nombre1Chofer { get; set; }
        public string Nombre2Chofer { get; set; }
        public string Apellido1Chofer { get; set; }
        public string Apellido2Chofer { get; set; }
        public string TelefonoChofer { get; set; }

        #endregion

        #region Constructor

        public ChoferModel()
        {
            IdChofer = string.Empty;
            Nombre1Chofer = string.Empty;
            Nombre2Chofer = string.Empty;
            Apellido1Chofer = string.Empty;
            Apellido2Chofer = string.Empty;
            TelefonoChofer = string.Empty;
        }
        #endregion
    }
}
