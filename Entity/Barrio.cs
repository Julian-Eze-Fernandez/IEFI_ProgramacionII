using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Barrio
    {
        #region Atributos

        private string barr_cod;
        private string barr_nombre;
        private char prov_cod;

        #endregion

        #region Constructores

        public Barrio()
        {

        }

        public Barrio(string br_cod, string br_nombre, char pr_cod )
        {
            barr_cod = br_cod;
            barr_nombre = br_nombre;
            prov_cod = pr_cod;
        }
        #endregion

        #region Propiedades

        public string Barr_Cod { get { return barr_cod; } set { barr_cod = value; } }
        public string Barr_Nombre { get { return barr_nombre; } set { barr_nombre = value; } }
        public char Prov_Cod { get { return prov_cod; } set { prov_cod = value; } }

        #endregion
    }
}
