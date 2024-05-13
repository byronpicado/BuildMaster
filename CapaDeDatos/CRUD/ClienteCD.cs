using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDeDatos.CRUD
{
    public class ClienteCD
    {
        //Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        //Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        //obtenemos todos lo registro de la tabla cliente
        public DataTable ObtenerCliente()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM Cliente";
                Comando.CommandType = CommandType.Text;
                LectorDatos = Comando.ExecuteReader();
                Conexion.CerrarConexion();
                Tabla.Load(LectorDatos);
            }
            catch (Exception ex)
            {
                string excepxion = ex.Message;
            }
            return Tabla;
        }

        public bool Insertar(Cliente cliente)
        {
            bool agregado = false;
            try

            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Insert INTO Cliente (id_cliente,nombre1,nombre2,apellidoPaterno,apellidoMaterno,telefono,correo) VALUES (@id_cliente,@nombre1,@nombre2,@apellidoPaterno,@apellidoMaterno,@telefono,@correo)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_cliente", cliente.Id_cliente);
                Comando.Parameters.AddWithValue("@nombre1", cliente.nombre1);
                Comando.Parameters.AddWithValue("@nombre2", cliente.nombre2);
                Comando.Parameters.AddWithValue("@apellidoPaterno", cliente.apellidoPaterno);
                Comando.Parameters.AddWithValue("@apellidomaterno", cliente.apellidoMaterno);
                Comando.Parameters.AddWithValue("@telefono", cliente.telefono);
                Comando.Parameters.AddWithValue("@correo", cliente.correo);

              agregado =   Comando.ExecuteNonQuery()>0;
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
                return agregado;
            }
            catch (Exception ex)
            {
                String msj = ex.ToString();
                return false;
            }

        }
        //para editar un registro en la tabla Cliente
        public bool Editar(Cliente cliente)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE cliente SET nombre1 = @nombre1, nombre2 = @nombre2, apellidoPaterno = @apellidopaterno, apellidoMaterno = @apellidoMaterno, telefono = @telefono, correo = @correo WHERE Id_cliente = @Id_cliente";
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@id_cliente", cliente.Id_cliente);
                Comando.Parameters.AddWithValue("@nombre1", cliente.nombre1);
                Comando.Parameters.AddWithValue("@nombre2", cliente.nombre2);
                Comando.Parameters.AddWithValue("@apellidoPaterno", cliente.apellidoPaterno);
                Comando.Parameters.AddWithValue("@apellidomaterno", cliente.apellidoMaterno);
                Comando.Parameters.AddWithValue("@telefono", cliente.telefono);
                Comando.Parameters.AddWithValue("@correo", cliente.correo);
                editado = Comando.ExecuteNonQuery() > 0;
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
                return editado;
            }
            catch (Exception ex)
            {
                String msj = ex.ToString();
                return false;
            }
        }
        //para eliminar un objeto de la tabla
        public bool Eliminar(int clienteId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM Categorias WHERE Id_cliente = @Id_cliente";
                Comando.Parameters.AddWithValue("@Id_cliente", clienteId);
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
