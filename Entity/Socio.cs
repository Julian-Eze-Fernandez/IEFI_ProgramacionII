using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Socio
    {
        #region Atributos

        private string socio_cod;
        private string nombre;
        private string apellido;
        private char sexo_cod;
        private string domicilio;
        private string barr_cod;
        private decimal monto_mes;
        private DateTime fecha_alta;
        private DateTime fecha_baja;
        private char activo;

        #endregion

        #region Constructores

        public Socio()
        {

        }
        public Socio(string soc_cod)
        {
            socio_cod = soc_cod;
        }

        public Socio(string soc_cod, string nom, string ape, char sex_cod, string dom, string bar_cod, 
                    decimal mon_mes, DateTime fec_alt, DateTime fec_baj, char act)
        {
            socio_cod = soc_cod;
            nombre = nom;
            apellido = ape;
            sexo_cod = sex_cod;
            domicilio = dom;
            barr_cod = bar_cod;
            monto_mes = mon_mes;
            fecha_alta = fec_alt;
            fecha_baja = fec_baj;
            activo = act;
        }

        #endregion

        #region Propiedades

        public string Socio_Cod { get { return socio_cod; } set { socio_cod = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public char Sexo_Cod { get { return sexo_cod; } set { sexo_cod = value; } }
        public string Domicilio { get { return domicilio; } set { domicilio = value; } }
        public string Barr_Cod { get { return barr_cod; } set { barr_cod = value; } }
        public decimal Monto_Mes { get { return monto_mes; } set { monto_mes = value; } }
        public DateTime Fecha_Alta { get { return fecha_alta; } set { fecha_alta = value; } }
        public DateTime Fecha_Baja { get { return fecha_baja; } set { fecha_baja = value; } }
        public char Activo { get { return activo; } set { activo = value; } }

        #endregion


    }
}
