using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Models
{
    public class PerfilModel
    {
        #region Propiedades
        public int CodigoPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public bool? Estado { get; set; }

        #endregion

        #region Constructor

        public PerfilModel()
        {
            CodigoPerfil = 0;
            NombrePerfil = string.Empty;
            Estado = true;
        }
        #endregion
    }
}
