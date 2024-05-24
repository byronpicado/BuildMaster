using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace CapaDeDatos.CRUD
{
    public class MantenimientoCD
    {
        // Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        // Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        // Obtenemos todos los registros de la tabla mantenimiento
        public DataTable ObtenerMantenimiento()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM Mantenimiento";
                Comando.CommandType = CommandType.Text;
                LectorDatos = Comando.ExecuteReader();
                Tabla.Load(LectorDatos);
                LectorDatos.Close();
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                string excepcion = ex.Message;
                // Manejar o registrar el error adecuadamente
            }
            finally
            {
                if (LectorDatos != null && !LectorDatos.IsClosed)
                {
                    LectorDatos.Close();
                }
                if (Comando.Connection != null && Comando.Connection.State == ConnectionState.Open)
                {
                    Conexion.CerrarConexion();
                }
            }
            return Tabla;
        }

        public bool Insertar(Mantenimiento mantenimiento)
        {
            bool agregado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "INSERT INTO Mantenimiento (id_mantenimiento, fecha_mantenimiento, descripcion) VALUES (@id_mantenimiento, @fecha_mantenimiento, @descripcion)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_mantenimiento", mantenimiento.id_mantenimiento);
                Comando.Parameters.AddWithValue("@fecha_mantenimiento", mantenimiento.fecha_mantenimiento);
                Comando.Parameters.AddWithValue("@descripcion", mantenimiento.descripcion);

                agregado = Comando.ExecuteNonQuery() > 0;
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
                // Manejar o registrar el error adecuadamente
            }
            finally
            {
                if (Comando.Connection != null && Comando.Connection.State == ConnectionState.Open)
                {
                    Conexion.CerrarConexion();
                }
            }
            return agregado;
        }

        // Para editar un registro en la tabla Mantenimiento
        public bool Editar(Mantenimiento mantenimiento)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE Mantenimiento SET fecha_mantenimiento = @fecha_mantenimiento, descripcion = @descripcion WHERE id_mantenimiento = @id_mantenimiento";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_mantenimiento", mantenimiento.id_mantenimiento);
                Comando.Parameters.AddWithValue("@fecha_mantenimiento", mantenimiento.fecha_mantenimiento);
                Comando.Parameters.AddWithValue("@descripcion", mantenimiento.descripcion);

                editado = Comando.ExecuteNonQuery() > 0;
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
                // Manejar o registrar el error adecuadamente
            }
            finally
            {
                if (Comando.Connection != null && Comando.Connection.State == ConnectionState.Open)
                {
                    Conexion.CerrarConexion();
                }
            }
            return editado;
        }

        public bool Eliminar(int mantenimientoId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM Mantenimiento WHERE id_mantenimiento = @id_mantenimiento";
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@id_mantenimiento", mantenimientoId);

                eliminado = Comando.ExecuteNonQuery() > 0;
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
                // Manejar o registrar el error adecuadamente
            }
            finally
            {
                if (Comando.Connection != null && Comando.Connection.State == ConnectionState.Open)
                {
                    Conexion.CerrarConexion();
                }
            }
            return eliminado;
        }
    }
}
