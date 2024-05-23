using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos.CRUD
{
    public class ResponsableCD
    {
        // Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        // Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        // Obtenemos todos los registros de la tabla Responsable
        public DataTable ObtenerResponsable()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM Responsable";
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

        public bool Insertar(Responsable responsable)
        {
            bool agregado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "INSERT INTO Responsable (id_responsable, nombre1, nombre2, apellidoPaterno, apellidoMaterno, cargo) VALUES (@id_responsable, @nombre1, @nombre2, @apellidoPaterno, @apellidoMaterno, @cargo)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_responsable", responsable.id_responsable);
                Comando.Parameters.AddWithValue("@nombre1", responsable.nombre1);
                Comando.Parameters.AddWithValue("@nombre2", responsable.nombre2);
                Comando.Parameters.AddWithValue("@apellidoPaterno", responsable.apellidoPaterno);
                Comando.Parameters.AddWithValue("@apellidoMaterno", responsable.apellidoMaterno);
                Comando.Parameters.AddWithValue("@cargo", responsable.cargo);

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

        // Para editar un registro en la tabla Responsable
        public bool Editar(Responsable responsable)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE Responsable SET nombre1 = @nombre1, nombre2 = @nombre2, apellidoPaterno = @apellidoPaterno, apellidoMaterno = @apellidoMaterno, cargo = @cargo WHERE id_responsable = @id_responsable";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_responsable", responsable.id_responsable);
                Comando.Parameters.AddWithValue("@nombre1", responsable.nombre1);
                Comando.Parameters.AddWithValue("@nombre2", responsable.nombre2);
                Comando.Parameters.AddWithValue("@apellidoPaterno", responsable.apellidoPaterno);
                Comando.Parameters.AddWithValue("@apellidoMaterno", responsable.apellidoMaterno);
                Comando.Parameters.AddWithValue("@cargo", responsable.cargo);

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

//para eliminar un objeto de la tabla
public bool Eliminar(int responsableId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM Responsable WHERE id_responsable = @id_responsable";
                Comando.Parameters.AddWithValue("@id_responsable", responsableId);
                eliminado = Comando.ExecuteNonQuery() > 0;
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
                return eliminado;
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
                return false;
            }

        }


    }

}
