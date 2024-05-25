using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos.CRUD
{
    public class ResponsableCD
    {
        // Cadena de conexión
        private ConexionCD Conexion = new ConexionCD();

        // Obtenemos todos los registros de la tabla Responsable
        public DataTable ObtenerResponsable()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection connection = Conexion.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Responsable", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }
            return tabla;
        }

        // Para insertar un nuevo registro en la tabla Responsable
        public bool Insertar(Responsable responsable)
        {
            using (SqlConnection connection = Conexion.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Responsable (id_responsable, nombre1, nombre2, apellidoPaterno, apellidoMaterno, cargo) VALUES (@id_responsable, @nombre1, @nombre2, @apellidoPaterno, @apellidoMaterno, @cargo)", connection))
                {
                    command.Parameters.AddWithValue("@id_responsable", responsable.id_responsable);
                    command.Parameters.AddWithValue("@nombre1", responsable.nombre1);
                    command.Parameters.AddWithValue("@nombre2", responsable.nombre2);
                    command.Parameters.AddWithValue("@apellidoPaterno", responsable.apellidoPaterno);
                    command.Parameters.AddWithValue("@apellidoMaterno", responsable.apellidoMaterno);
                    command.Parameters.AddWithValue("@cargo", responsable.cargo);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // Para editar un registro en la tabla Responsable
        public bool Editar(Responsable responsable)
        {
            using (SqlConnection connection = Conexion.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand("UPDATE Responsable SET nombre1 = @nombre1, nombre2 = @nombre2, apellidoPaterno = @apellidoPaterno, apellidoMaterno = @apellidoMaterno, cargo = @cargo WHERE id_responsable = @id_responsable", connection))
                {
                    command.Parameters.AddWithValue("@id_responsable", responsable.id_responsable);
                    command.Parameters.AddWithValue("@nombre1", responsable.nombre1);
                    command.Parameters.AddWithValue("@nombre2", responsable.nombre2);
                    command.Parameters.AddWithValue("@apellidoPaterno", responsable.apellidoPaterno);
                    command.Parameters.AddWithValue("@apellidoMaterno", responsable.apellidoMaterno);
                    command.Parameters.AddWithValue("@cargo", responsable.cargo);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // Para eliminar un registro de la tabla Responsable
        public bool Eliminar(int responsableId)
        {
            using (SqlConnection connection = Conexion.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Responsable WHERE id_responsable = @id_responsable", connection))
                {
                    command.Parameters.AddWithValue("@id_responsable", responsableId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}

