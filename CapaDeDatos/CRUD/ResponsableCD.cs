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
    public class ResponsableCD
    {
        //Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        //Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        //obtenemos todos lo registro de la tabla responsable
        public DataTable ObtenerResponsable()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM Responsable";
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

        public bool Insertar( Responsable responsable)
        {
            bool agregado = false;
            try

            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Insert INTO Responsable (id_responsable,nombre1,nombre2,apellidoPaterno,apellidoMaterno,cargo) VALUES (@id_responsable,@nombre1,@nombre2,@apellidoPaterno,@apellidoMaterno,@cargo)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_responsable", responsable.id_responsable);
                Comando.Parameters.AddWithValue("@nombre1", responsable.nombre1);
                Comando.Parameters.AddWithValue("@nombre2", responsable.nombre2);

                Comando.Parameters.AddWithValue("@apellidoPaterno", responsable.apellidoPaterno);

                Comando.Parameters.AddWithValue("@apellidoMaterno", responsable.apellidoMaterno);
                Comando.Parameters.AddWithValue("@cargo", responsable.cargo);

               agregado = Comando.ExecuteNonQuery()>0;
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
        //para editar un registro en la tabla Responsable
        public bool Editar(Responsable responsable)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE responsable SET nombre1=@nombre1,nombre2=@nombre2,apellidoPaterno=@apellidopatero,apellidoMaterno=@apellidoMaterno,cargo=@cargo WHERE id_responsable=@id_responsabel";
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@id_responsable", responsable.id_responsable);
                Comando.Parameters.AddWithValue("@nombre1", responsable.nombre1);
                Comando.Parameters.AddWithValue("@nombre2", responsable.nombre2);

                Comando.Parameters.AddWithValue("@apellidoPaterno", responsable.apellidoPaterno);

                Comando.Parameters.AddWithValue("@apellidoMaterno", responsable.apellidoMaterno);
                Comando.Parameters.AddWithValue("@cargo", responsable.cargo);
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
        public bool Eliminar(int responsableId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM Responsable WHERE id_responsable = @id_responsable";
                Comando.Parameters.AddWithValue("@id_responsable", responsableId);
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
