using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sexo
    {
        #region Atributos

        private char sexo_cod;
        private string nombre_sexo;

        #endregion

        #region Constructor

        public Sexo()
        {

        }

        #endregion

        #region Propiedades

        public char Sexo_Cod { get { return sexo_cod; } set { sexo_cod = value; } }
        public string Nombre_Sexo { get { return nombre_sexo; } set { nombre_sexo = value; } }

        #endregion
    }
}
