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
    public class PersonalCD
    {       //Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        //Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        //obtenemos todos lo registro de la tabla Personal
        public DataTable ObtenerPersonal()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM Personal";
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

        public bool Insertar(Personal personal)
        {
            bool agregado = false;
            try

            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Insert INTO Personal (id_personal,nombre1,nombre2,apellidoPaterno,apellidoMaterno,cargo,fecha_contratacion) VALUES (@id_personal,@nombre1,@nombre2,@apellidoPaterno,@apellidoMaterno,@cargo,@fecha_contratacion)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_personal", personal.id_personal);
                Comando.Parameters.AddWithValue("@nombre1", personal.nombre1);
                Comando.Parameters.AddWithValue("@nombre2", personal.nombre2);
                Comando.Parameters.AddWithValue("@apellidoPaterno", personal.apellidoPaterno);
                Comando.Parameters.AddWithValue("@apellidoMaterno", personal.apellidoMaterno);
                Comando.Parameters.AddWithValue("@cargo", personal.cargo);
                Comando.Parameters.AddWithValue("@fecha_contratacion", personal.fecha_contratacion);


              agregado=  Comando.ExecuteNonQuery()>0;
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
        //para editar un registro en la tabla Personal
        public bool Editar(Personal personal)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE personal SET nombre1=@nombre1,nombre2=nombre2,apellidoPaterno=@apellidoPaterno,apellidoMaterno=@apellidoMaterno,cargo=@cargo,fecha_contratacion=@fecha_contratacion WHERE id_personal = @id_personal";
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@id_personal", personal.id_personal);
                Comando.Parameters.AddWithValue("@nombre1", personal.nombre1);
                Comando.Parameters.AddWithValue("@nombre2", personal.nombre2);
                Comando.Parameters.AddWithValue("@apellidoPaterno", personal.apellidoPaterno);
                Comando.Parameters.AddWithValue("@apellidoMaterno", personal.apellidoMaterno);
                Comando.Parameters.AddWithValue("@cargo", personal.cargo);
                Comando.Parameters.AddWithValue("@fecha_contratacion", personal.fecha_contratacion);
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
        public bool Eliminar(int personalId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM Personal WHERE id_personal = @id_personal";
                Comando.Parameters.AddWithValue("@id_personal", personalId);
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


