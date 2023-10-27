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
    public class NegSocio
    {
        AdminisSocio DatosObjSocio = new AdminisSocio();

        public int abmSocios(string accion, Socio objSocio)
        {
            return DatosObjSocio.abmSocios(accion, objSocio);
        }

        public DataSet listadoSocios(string cual)
        {
            return DatosObjSocio.listadoSocios(cual);
        }
    }
}
