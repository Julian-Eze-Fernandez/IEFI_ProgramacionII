using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CapaDatos
{
    public class AdminisBarrio : DatosConexion
    {
        public int abmBarrios(string accion, Barrio objBarrio)
        {
            int resultado = -1;  // controlar que se realize la operacion con exito
            string orden = string.Empty; // para guardar consulta sql

            if (accion == "Alta") // para agregar un producto nuevo
            {
                orden = $"insert into barrios (Barr_Cod, Barr_Nombre, Prov_Cod) values ('{objBarrio.Barr_Cod}', '{objBarrio.Barr_Nombre}', '{objBarrio.Prov_Cod}');";
            }

            if (accion == "Modificar") // para modificar un existente
                orden = $"update barrios set Barr_Nombre='{objBarrio.Barr_Nombre}', Prov_Cod='{objBarrio.Prov_Cod}' WHERE Barr_Cod like '%{objBarrio.Barr_Cod}%';";


            if (accion == "Borrar") // para borrar un existente
                orden = $"delete from barrios where Barr_Cod =  '{objBarrio.Barr_Cod}';";


            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Errror al tratar de guardar, borrar o modificar un barrio.", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoBarrios(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos")
                orden = "select * from barrios where Barr_Cod = " + int.Parse(cual) + ";";
            else
                orden = "select * from barrios;";

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
                throw new Exception("Error al listar barrios", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

        public List<Barrio> ObtenerBarrios()
        {
            List<Barrio> lista = new List<Barrio>();
            string orden = "Select Barr_Cod, barr_nombre From Barrios";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            SqlDataReader dr;
            try
            {
                Abrirconexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Barrio B = new Barrio();// instancio R como un objeto Rubro
                    B.Barr_Cod = dr.GetString(0); //se puede acceder a los campos con el tipo de dato, en este caso un entero
                    B.Barr_Nombre = dr.GetString(1);
                    lista.Add(B);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Barrios", e);
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
