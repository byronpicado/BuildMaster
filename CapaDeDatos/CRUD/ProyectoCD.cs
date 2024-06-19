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
        // Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        // Variables a Utilizar
        private SqlDataReader LectorDatos;
        private DataTable Tabla = new DataTable();

        public DataTable ObtenerProyectos()
        {
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = "ObtenerProyectos"; 
                comando.CommandType = CommandType.StoredProcedure;
                LectorDatos = comando.ExecuteReader();
                Tabla.Load(LectorDatos);
                Conexion.CerrarConexion();
            }

            return Tabla;
        }

        public bool Insertar(Proyecto proyecto)
        {
            bool agregado = false;
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = "InsertarProyecto"; 
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codigo", proyecto.codigo);
               
                comando.Parameters.AddWithValue("@descripcion", proyecto.descripcion);
                comando.Parameters.AddWithValue("@fecha_inicio", proyecto.fecha_inicio);
                comando.Parameters.AddWithValue("@fecha_fin", proyecto.fecha_fin);
                comando.Parameters.AddWithValue("@estado", proyecto.Estado);
                agregado = comando.ExecuteNonQuery() > 0;
                comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }

            return agregado;
        }

        public bool Editar(Proyecto proyecto)
        {
            bool editado = false;
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = "ActualizarProyecto"; 
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_proyecto", proyecto.id_proyecto);
                comando.Parameters.AddWithValue("@codigo", proyecto.codigo);
                comando.Parameters.AddWithValue("@descripcion", proyecto.descripcion);
                comando.Parameters.AddWithValue("@fecha_inicio", proyecto.fecha_inicio);
                comando.Parameters.AddWithValue("@fecha_fin", proyecto.fecha_fin);
                comando.Parameters.AddWithValue("@estado", proyecto.Estado);
                editado = comando.ExecuteNonQuery() > 0;
                comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }

            return editado;
        }

        public bool Eliminar(int proyectoId)
        {
            bool eliminado = false;
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = "EliminarProyecto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_proyecto", proyectoId);
                eliminado = comando.ExecuteNonQuery() > 0;
                comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }

            return eliminado;
        }

        public bool ExisteProyecto(Proyecto proyecto)
        {
            bool existe = false;
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = "ExisteProyecto"; 
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codigo", proyecto.codigo);
                existe = (int)comando.ExecuteScalar() > 0;
                comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }

            return existe;
        }

        public bool ExisteOtroProyecto(Proyecto proyecto)
        {
            bool existe = false;
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = "ExisteOtroProyecto"; 
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codigo", proyecto.codigo);
                comando.Parameters.AddWithValue("@id_proyecto", proyecto.id_proyecto);
                existe = (int)comando.ExecuteScalar() > 0;
                comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }

            return existe;
        }

        public bool ProyectoConProyectoDetalle(int proyectoId)
        {
            bool existe = false;
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = "ProyectoConProyectoDetalle"; 
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_proyecto", proyectoId);
                existe = (int)comando.ExecuteScalar() > 0;
                comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }

            return existe;
        }
    }
}
