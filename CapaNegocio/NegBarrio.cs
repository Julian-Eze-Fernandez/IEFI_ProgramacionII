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
    public class NegBarrio
    {

        AdminisBarrio DatosObjBarrio = new AdminisBarrio();

        public int abmBarrios(string accion, Barrio objBarrio)
        {
            return DatosObjBarrio.abmBarrios(accion, objBarrio);
        }

        public DataSet listadoBarrios(string cual)
        {
            return DatosObjBarrio.listadoBarrios(cual);
        }
        public List<Barrio> ObtenerBarrios()
        {
            return DatosObjBarrio.ObtenerBarrios();
        }

    }
}
