using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        #region Atributos

        private char prov_cod;
        private string prov_nombre;

        #endregion

        #region Constructor

        public Provincia()
        {

        }

        #endregion

        #region Propiedades

        public char Prov_Cod { get { return prov_cod; } set { prov_cod = value; } }
        public string Prov_Nombre { get { return prov_nombre; } set { prov_nombre = value; } }

        #endregion
    }
}
