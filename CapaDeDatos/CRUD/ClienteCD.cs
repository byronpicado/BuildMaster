using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace CapaDeDatos.CRUD
{
    public class ClienteCD
    {
        // Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        // Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        // Obtenemos todos los registros de la tabla cliente
        public DataTable ObtenerCliente()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM Cliente";
                Comando.CommandType = CommandType.Text;
                LectorDatos = Comando.ExecuteReader();
                Tabla.Load(LectorDatos);
                LectorDatos.Close();
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                string excepxion = ex.Message;
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

        public bool Insertar(Cliente cliente)
        {
            bool agregado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "INSERT INTO Cliente (id_cliente, nombre1, nombre2, apellidoPaterno, apellidoMaterno, telefono, correo) VALUES (@id_cliente, @nombre1, @nombre2, @apellidoPaterno, @apellidoMaterno, @telefono, @correo)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_cliente", cliente.Id_cliente);
                Comando.Parameters.AddWithValue("@nombre1", cliente.nombre1);
                Comando.Parameters.AddWithValue("@nombre2", cliente.nombre2);
                Comando.Parameters.AddWithValue("@apellidoPaterno", cliente.apellidoPaterno);
                Comando.Parameters.AddWithValue("@apellidoMaterno", cliente.apellidoMaterno);
                Comando.Parameters.AddWithValue("@telefono", cliente.telefono);
                Comando.Parameters.AddWithValue("@correo", cliente.correo);

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

        // Para editar un registro en la tabla Cliente
        public bool Editar(Cliente cliente)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE Cliente SET nombre1 = @nombre1, nombre2 = @nombre2, apellidoPaterno = @apellidoPaterno, apellidoMaterno = @apellidoMaterno, telefono = @telefono, correo = @correo WHERE id_cliente = @id_cliente";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_cliente", cliente.Id_cliente);
                Comando.Parameters.AddWithValue("@nombre1", cliente.nombre1);
                Comando.Parameters.AddWithValue("@nombre2", cliente.nombre2);
                Comando.Parameters.AddWithValue("@apellidoPaterno", cliente.apellidoPaterno);
                Comando.Parameters.AddWithValue("@apellidoMaterno", cliente.apellidoMaterno);
                Comando.Parameters.AddWithValue("@telefono", cliente.telefono);
                Comando.Parameters.AddWithValue("@correo", cliente.correo);

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

        // Para eliminar un objeto de la tabla
        public bool Eliminar(int clienteId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM Cliente WHERE id_cliente = @id_cliente";
                Comando.Parameters.AddWithValue("@id_cliente", clienteId);
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
