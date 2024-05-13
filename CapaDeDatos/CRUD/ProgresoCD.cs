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
    public class ProgresoCD
    {
        //Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        //Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        //obtenemos todos lo registro de la tabla progreso
        public DataTable ObtenerProgreso()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM Progreso";
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

        public bool Insertar(Progreso progreso)
        {
            bool agregado = false;
            try

            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Insert INTO Progreso (id_progreso,descripcion,fecha_registro) VALUES (@id_progreso,@descripcion,@fecha_registro)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_progreso", progreso.id_progreso);
                Comando.Parameters.AddWithValue("@descripcion", progreso.descripcion);
                Comando.Parameters.AddWithValue("@fecha_registro", progreso.fecha_registro);
                



              agregado =Comando.ExecuteNonQuery()>0;
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
        //para editar un registro en la tabla Progreso
        public bool Editar(Progreso progreso)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE progreso SET descripcion=@descripcion,fecha_registro=@fecha_registro WHERE id_progreso = @id_progreso";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_progreso", progreso.id_progreso);
                Comando.Parameters.AddWithValue("@descripcion", progreso.descripcion);
                Comando.Parameters.AddWithValue("@fecha_registro", progreso.fecha_registro);
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
        public bool Eliminar(int progresoId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM Progreso WHERE id_progreso = @id_progreso";
                Comando.Parameters.AddWithValue("@id_progreso", progresoId);
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