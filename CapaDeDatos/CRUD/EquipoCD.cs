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
    public class EquipoCD
    {
        //Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        //Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        //obtenemos todos lo registro de la tabla equipo
        public DataTable ObtenerEquipo()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM Equipo";
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

        public bool Insertar(Equipo equipo)
        {
            bool agregado = false;  
            try

            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Insert INTO equipo (id_equipo,tipo,marca,fecha_adquisicion) VALUES (@id_equipo,@tipo,@marca,@fecha_adquisicion)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_equipo",equipo.id_equipo);
                Comando.Parameters.AddWithValue("@tipo", equipo.tipo);
                Comando.Parameters.AddWithValue("@marca", equipo.marca);
                Comando.Parameters.AddWithValue("@fecha_adquisicion", equipo.fecha_adquisicion);
                

               agregado= Comando.ExecuteNonQuery()>0;
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
        //para editar un registro en la tabla Equipo
        public bool Editar(Equipo equipo)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE equipo SET tipo=@tipo,marca=@marca,fecha_adquisicion=@fecha_adquisicion WHERE id_equipo = @id_equipo";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_equipo", equipo.id_equipo);
                Comando.Parameters.AddWithValue("@tipo", equipo.tipo);
                Comando.Parameters.AddWithValue("@marca", equipo.marca);
                Comando.Parameters.AddWithValue("@fecha_adquisicion", equipo.fecha_adquisicion);
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
        public bool Eliminar(int equipoId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM Equipo WHERE id_equipo = @id_equipo";
                Comando.Parameters.AddWithValue("@id_equipo", equipoId);
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

