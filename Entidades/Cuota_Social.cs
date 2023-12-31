﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuota_Social
    {
        #region Atributos

        private string socio_cod;
        private char anio;
        private char mes;
        private decimal monto_cuota;
        private char pagada;

        #endregion

        #region Constructores

        public Cuota_Social()
        {

        }

        #endregion

        #region Propiedades

        public string Socio_Cod { get { return socio_cod; } set { socio_cod = value; } }
        public char Anio { get { return anio; } set { anio = value; } }
        public char Mes { get { return mes; } set { mes = value; } }
        public decimal Monto_Cuota { get { return monto_cuota; } set { monto_cuota = value; } }
        public char Pagada { get { return pagada; } set { pagada = value; } }

        #endregion
    }
}
