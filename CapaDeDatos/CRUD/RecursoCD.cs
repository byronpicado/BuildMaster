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
        
      public   class RecursoCD
    {
        //Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        //Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        //obtenemos todos lo registro de la tabla recurso
        public DataTable ObtenerRecurso()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM Recurso";
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

        public bool Insertar(Recurso recurso)
        {
            bool agregado = false;
            try

            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Insert INTO Recuro (id_recurso,tipo,descripcion,costo) VALUES (@id_recurso,@tipo,@descripcion,@costo)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_recurso", recurso.id_recurso);
                Comando.Parameters.AddWithValue("@tipo", recurso.tipo);
                Comando.Parameters.AddWithValue("@descripcion", recurso.descripcion);
                Comando.Parameters.AddWithValue("@costo", recurso.costo);




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
        //para editar un registro en la tabla Recurso
        public bool Editar(Recurso recurso)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE recurso SET tipo=@tipo,descripcion=@descripcion,costo=@costo WHERE id_recurso=@id_recurso ";
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@id_recurso", recurso.id_recurso);
                Comando.Parameters.AddWithValue("@tipo", recurso.tipo);
                Comando.Parameters.AddWithValue("@descripcion", recurso.descripcion);
                Comando.Parameters.AddWithValue("@costo", recurso.costo);
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
        public bool Eliminar(int recursoId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM Recurso WHERE id_recurso = @id_recurso";
                Comando.Parameters.AddWithValue("@id_recurso", recursoId);
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
