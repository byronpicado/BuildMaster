using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.CRUD
{
    public class MantenimientoCD
    {
        //Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        //Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        //obtenemos todos lo registro de la tabla mantenimiento
        public DataTable ObtenerMantenimiento()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM Mantenimiento";
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

        public bool Insertar(Mantenimiento mantenimiento)
        {
            bool agregado = false;
            try

            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Insert INTO Mantenimiento (id_mantenimiento,fecha_mantenimiento,descripcion) VALUES (@id_mantenimiento,@fecha_mantenimiento,@descripcion)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_mantenimiento", mantenimiento.id_mantenimiento);
                Comando.Parameters.AddWithValue("@fecha_mantenimiento", mantenimiento.fecha_mantenimiento);
                Comando.Parameters.AddWithValue("@descripcion",mantenimiento.descripcion);


              agregado=Comando.ExecuteNonQuery()>0;
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
        //para editar un registro en la tabla Mantenimiento
        public bool Editar(Mantenimiento mantenimiento)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE mantenimiento SET fecha_mantenimiento=@fecha_mantenimiento,descripcion=@descripcion WHERE id_mantenimiento = @id_mantenimiento";
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@id_mantenimiento", mantenimiento.id_mantenimiento);
                Comando.Parameters.AddWithValue("@fecha_mantenimiento", mantenimiento.fecha_mantenimiento);
                Comando.Parameters.AddWithValue("@descripcion", mantenimiento.descripcion);
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
        public bool Eliminar(int categoriaId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM Categorias WHERE Id = @Id";
                Comando.Parameters.AddWithValue("@Id", categoriaId);
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
