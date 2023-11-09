using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AdminisProvincias : DatosConexion
    {
        public DataSet listadoProvincias(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos")
                orden = "select * from provincias where Prov_Cod = " + int.Parse(cual) + ";";
            else
                orden = "select * from provincias;";

            SqlCommand cmd = new SqlCommand(orden, conexion);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar provincias", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

        public List<Provincia> ObtenerProvincias()
        {
            List<Provincia> lista = new List<Provincia>();
            string orden = "Select Prov_Cod, prov_nombre From Provincias";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            SqlDataReader dr;
            try
            {
                Abrirconexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Provincia P = new Provincia();// instancio R como un objeto Rubro
                    P.Prov_Cod = dr.GetString(0)[0]; //se puede acceder a los campos con el tipo de dato, en este caso un entero
                    P.Prov_Nombre = dr.GetString(1);
                    lista.Add(P);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Provincias", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return lista;
        }
    }
}
