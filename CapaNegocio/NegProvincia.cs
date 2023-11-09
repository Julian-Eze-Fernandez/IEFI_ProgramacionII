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
    public class NegProvincia
    {
        AdminisProvincias DatosObjProvincia = new AdminisProvincias();

        public DataSet listadoProvincias(string cual)
        {
            return DatosObjProvincia.listadoProvincias(cual);
        }

        public List<Provincia> ObtenerProvincias()
        {
            return DatosObjProvincia.ObtenerProvincias();
        }
    }
}
