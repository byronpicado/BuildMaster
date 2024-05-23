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
    public class ProyectoCD
    {
        //Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        //Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        //obtenemos todos lo registro de la tabla proyecto
        public DataTable ObtenerProyecto()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM Proyecto";
                Comando.CommandType = CommandType.Text;
                LectorDatos = Comando.ExecuteReader();
                Tabla.Load(LectorDatos);
                LectorDatos.Close();
                Conexion.CerrarConexion();
              
            }
            catch (Exception ex)
            {
                string excepxion = ex.Message;
            }
            return Tabla;
        }

        public bool Insertar(Proyecto proyecto)
        {
            bool agregado = false;
            try

            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Insert INTO Proyecto(id_proyecto,id_cliente,id_responsable,nombre,descripcion,fecha_inicio,fecha_fin,Estado) VALUES (@id_proyecto,@id_cliente,@id_responsable,@nombre,@descripcion,@fecha_inicio,@fecha_fin,@Estado)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_proyecto", proyecto.id_proyecto);
                Comando.Parameters.AddWithValue("@id_cliente", proyecto.id_cliente);
                Comando.Parameters.AddWithValue("@id_responsable", proyecto.id_responsable);
                Comando.Parameters.AddWithValue("@nombre", proyecto.nombre);
                Comando.Parameters.AddWithValue("@descripcion", proyecto.descripcion);
                Comando.Parameters.AddWithValue("@fecha_inicio", proyecto.fecha_inicio);
                Comando.Parameters.AddWithValue("@fecha_fin", proyecto.fecha_fin);
                Comando.Parameters.AddWithValue("@Estado", proyecto.Estado);




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
        //para editar un registro en la tabla Proyecto
        public bool Editar(Proyecto proyecto)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE proyecto SET id_cliente=@id_cliente,id_responsable=@id_responsable,nombre=@nombre,descripcion=@descripcion,fecha_inicio=@fecha_inicio,fecha_fin=fecha_fin,Estado=@Estado WHERE id_proyecto=@id_proyecto";
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@id_proyecto", proyecto.id_proyecto);
                Comando.Parameters.AddWithValue("@id_cliente", proyecto.id_cliente);
                Comando.Parameters.AddWithValue("@id_responsable", proyecto.id_responsable);
                Comando.Parameters.AddWithValue("@nombre", proyecto.nombre);
                Comando.Parameters.AddWithValue("@descripcion", proyecto.descripcion);
                Comando.Parameters.AddWithValue("@fecha_inicio", proyecto.fecha_inicio);
                Comando.Parameters.AddWithValue("@fecha_fin", proyecto.fecha_fin);
                Comando.Parameters.AddWithValue("@Estado", proyecto.Estado);
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
        public bool Eliminar(int proyectoId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM Proyecto WHERE id_proyecto = @id_proyecto";
                Comando.Parameters.AddWithValue("@id_proyecto", proyectoId);
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