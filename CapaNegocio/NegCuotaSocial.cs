using CapaDatos;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegCuotaSocial
    {
        AdminisCuotaSocial DatosObjCuotaSocial = new AdminisCuotaSocial();

        public int abmCuotas_Sociales(string accion, Cuota_Social objCuota_Social)
        {
            return DatosObjCuotaSocial.abmCuotas_Sociales(accion, objCuota_Social);
        }

        public DataSet listadoCuotas_Sociales(string cual)
        {
            return DatosObjCuotaSocial.listadoCuotas_Sociales(cual);
        }

        public bool ExisteCodigoSocio(string codigoSocio)
        {
            return DatosObjCuotaSocial.ExisteCodigoSocio(codigoSocio);
        }
    }
}
