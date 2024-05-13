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
    public class TareaCD
    {
        //Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        //Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        //obtenemos todos lo registro de la tabla Tarea
        public DataTable ObtenerProyectoDetalle()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM Tarea";
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

        public bool Insertar(Tarea tarea)
        {
            bool agregado = false;
            try

            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Insert INTO Tarea (id_tarea,descripcion,fecha_inicio,fecha_fin,estado) VALUES (@id_tarea,@descripcion,@fecha_inicio,@fecha_fin,@estado)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_tarea", tarea.id_tarea);
                Comando.Parameters.AddWithValue("@descripcion", tarea.descripcion);
                Comando.Parameters.AddWithValue("@fecha_inicio", tarea.fecha_inicio);

                Comando.Parameters.AddWithValue("@fecha_fin", tarea.fecha_fin);

                Comando.Parameters.AddWithValue("@estado", tarea.estado);
               agregado= Comando.ExecuteNonQuery() > 0;
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
        //para editar un registro en la tabla Tarea
        public bool Editar(Tarea tarea)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE tarea SET descripcion=@descripcion,fecha_inicio=@fecha_inicio,fecha_fin=@fecha_fin,estado=@estado WHERE id_tarea=@id_tarea";
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@id_tarea", tarea.id_tarea);
                Comando.Parameters.AddWithValue("@descripcion", tarea.descripcion);
                Comando.Parameters.AddWithValue("@fecha_inicio", tarea.fecha_inicio);
                Comando.Parameters.AddWithValue("@fecha_fin", tarea.fecha_fin);
                Comando.Parameters.AddWithValue("@estado", tarea.estado);
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
        public bool Eliminar(int tareaId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM Tarea WHERE id_tarea = @id_tarea";
                Comando.Parameters.AddWithValue("@id_tarea", tareaId);
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