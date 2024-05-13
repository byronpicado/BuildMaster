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
    public class MantenimientoEquipoCD
    {
        //Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        //Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        //obtenemos todos lo registro de la tabla mantenimientoEquipo
        public DataTable ObtenerMantenimientoEquipo()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM MantenimientoEquipo";
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

        public void Insertar(MantenimientoEquipo mantenimientoEquipo)
        {
            try

            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Insert INTO MantenimientoEquipo (id_mantenimiento_Equipo,id_mantenimiento,id_equipo) VALUES (@id_mantenimiento_Equipo,@id_mantenimiento,@id_equipo)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_mantenimiento_Equipo", mantenimientoEquipo.id_mantenimiento_Equipo);
                Comando.Parameters.AddWithValue("@id_mantenimiento", mantenimientoEquipo.id_mantenimiento);
                Comando.Parameters.AddWithValue("@id_equipo", mantenimientoEquipo.id_equipo); 


                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                String msj = ex.ToString();
            }

        }
        //para editar un registro en la tabla MantenimientoEquipo
        public bool Editar(MantenimientoEquipo mantenimientoEquipo)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE mantenimientoEquipo SET id_mantenimiento=@id_mantenimiento,id_equipo=@id_equipo WHERE id_mantenimiento_Equipo = @id_mantenimiento_Equipo";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_mantenimiento_Equipo", mantenimientoEquipo.id_mantenimiento_Equipo);
                Comando.Parameters.AddWithValue("@id_mantenimiento", mantenimientoEquipo.id_mantenimiento);
                Comando.Parameters.AddWithValue("@id_equipo", mantenimientoEquipo.id_equipo);
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
        public bool Eliminar(int mantenimientoEquipoId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM MantenimientoEquipo WHERE Id = @Id";
                Comando.Parameters.AddWithValue("@id_mantenimiento_Equipo", mantenimientoEquipoId);
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
