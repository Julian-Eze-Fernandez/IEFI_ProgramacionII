using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
using System.Data.OleDb;

namespace CapaDatos
{
    public class AdminisSocio : DatosConexion
    {
        public int abmSocios(string accion, Socio objSocio)
        {
            int resultado = -1;  // controlar que se realize la operacion con exito
            string orden = string.Empty; // para guardar consulta sql

            if (accion == "Alta") // para agregar un producto nuevo
            {
                orden = $"insert into socios (Socio_Cod, Nombre, Apellido, Sexo_Cod, Domicilio, Barr_Cod, Monto_Mes, Fecha_Alta, Fecha_Baja, Activo) values ('{objSocio.Socio_Cod}', '{objSocio.Nombre}', '{objSocio.Apellido}', '{objSocio.Sexo_Cod}', '{objSocio.Domicilio}' , '{objSocio.Barr_Cod}', {objSocio.Monto_Mes}, '{objSocio.Fecha_Alta}','{objSocio.Fecha_Baja}','{objSocio.Activo}' );";
            }

            if (accion == "Modificar") // para modificar un existente
                orden = $"update socios set Nombre='{objSocio.Nombre}', Apellido='{objSocio.Apellido}', Sexo_Cod='{objSocio.Sexo_Cod}', Domicilio='{objSocio.Domicilio}', Barr_Cod='{objSocio.Barr_Cod}', Monto_Mes={objSocio.Monto_Mes}, Fecha_Alta='{objSocio.Fecha_Alta}', Fecha_Baja='{objSocio.Fecha_Baja}', Activo='{objSocio.Activo}' WHERE socio_cod = '{objSocio.Socio_Cod}';";


            if (accion == "Borrar") // para borrar un existente
                orden = $"delete from socios where Socio_Cod =  '{objSocio.Socio_Cod}';";


            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Errror al tratar de guardar, borrar o modificar algun socio.", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoSocios(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos")
                orden = "select * from socios where Socio_Cod = " + int.Parse(cual) + ";";
            else
                orden = "select * from socios;";

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
                throw new Exception("Error al listar socios", e);
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
