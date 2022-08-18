using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Models
{
    public class UsuariosModel
    {
        #region Propiedades
        public int ID_USUARIO { get; set; }
        public string EMAIL { get; set; }
        public Byte[] PASS { get; set; }
        public string SALT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public string TIPO { get; set; }

        #endregion

        #region Constructor

        public UsuariosModel()
        {
            ID_USUARIO = 0;
            EMAIL = string.Empty;
            byte[] PASS = new byte[0];
            SALT = string.Empty;
            NOMBRE = string.Empty;
            APELLIDOS = string.Empty;
            TIPO = string.Empty;
        }
        #endregion
    }
}
