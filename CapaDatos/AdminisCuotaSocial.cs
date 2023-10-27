using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace CapaDatos
{
    public class AdminisCuotaSocial : DatosConexion
    {
        public int abmCuotas_Sociales(string accion, Cuota_Social objCuota_Social)
        {
            int resultado = -1;  // controlar que se realize la operacion con exito
            string orden = string.Empty; // para guardar consulta sql

            if (accion == "Alta") // para agregar un producto nuevo
            {
                orden = $"insert into cuotas_sociales (Socio_Cod, Anio, Mes, Monto_Cuota, Pagada) values ('{objCuota_Social.Socio_Cod}', '{objCuota_Social.Anio}', '{objCuota_Social.Mes}', '{objCuota_Social.Monto_Cuota}', '{objCuota_Social.Pagada}');";
            }

            if (accion == "Modificar") // para modificar un existente
                orden = $"update cuotas_sociales set Anio='{objCuota_Social.Anio}', Mes='{objCuota_Social.Mes}', Monto_Cuota='{objCuota_Social.Monto_Cuota}', Pagada='{objCuota_Social.Pagada}' WHERE socio_cod like '%{objCuota_Social.Socio_Cod}%';";


            if (accion == "Borrar") // para borrar un existente
                orden = "delete * from cuotas_sociales where Socio_Cod =" + objCuota_Social.Socio_Cod + ";";


            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Errror al tratar de guardar, borrar o modificar una cuota social.", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoCuotas_Sociales(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos")
                orden = "select * from cuotas_sociales where Socio_Cod = " + int.Parse(cual) + ";";
            else
                orden = "select * from cuotas_sociales;";

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
                throw new Exception("Error al listar cuotas sociales", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

    }
}
