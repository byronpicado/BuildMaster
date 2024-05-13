﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.CRUD
{
    public class ProyectoDetalleCD
    {
        //Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        //Variables 
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        //obtenemos todos lo registro de la tabla proyectoDetalle
        public DataTable ObtenerProyectoDetalle()
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM ProyectoDetalle";
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

        public bool Insertar(ProyectoDetalle proyectoDetalle)
        {
            bool agregado = false;
            try

            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Insert INTO ProyectoDetalle (id_proyectoDetalle,id_proyecto,id_cliente,id_responsable,id_recurso,id_tarea,id_progreso,id_equipo,id_Personal_proyecto,id_personal,descripcion,fecha_registro) VALUES (@id_proyectoDetalle,@id_proyecto,@id_cliente,@id_responsable,@id_recurso,@id_tarea,@id_progreso,@id_equipo,@id_Personal_proyecto,@id_personal,@descripcion,@fecha_registro)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@id_proyectoDetalle", proyectoDetalle.id_proyectoDetalle);
                Comando.Parameters.AddWithValue("@id_proyecto", proyectoDetalle.id_proyecto);
                Comando.Parameters.AddWithValue("@id_cliente",proyectoDetalle.id_cliente);
                Comando.Parameters.AddWithValue("@id_responsable", proyectoDetalle.id_responsable);
                Comando.Parameters.AddWithValue("id_recurso", proyectoDetalle.id_recurso);
                Comando.Parameters.AddWithValue("@id_tarea", proyectoDetalle.id_tarea);
                Comando.Parameters.AddWithValue("@id_progreso", proyectoDetalle.id_progreso);
                Comando.Parameters.AddWithValue("@id_equipo",proyectoDetalle.id_equipo);
                Comando.Parameters.AddWithValue("@id_Personal_proyecto", proyectoDetalle.id_Personal_proyecto);
                Comando.Parameters.AddWithValue("@id_personal", proyectoDetalle.id_personal);
                Comando.Parameters.AddWithValue("@descripcion", proyectoDetalle.descripcion);
                Comando.Parameters.AddWithValue("@fecha_registro", proyectoDetalle.fecha_registro);
                



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
        //para editar un registro en la tabla ProyectDetalle
        public bool Editar(ProyectoDetalle proyectoDetalle)
        {
            bool editado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE ProyectoDetalle SET id_proyecto=@id_proyecto,id_cliente=@id_cliente,id_responsable=@id_responsable,id_recurso=@id_recurso,id_tarea=@id_tarea,id_progreso=@id_progreso,id_equipo=@id_equipo,id_Personal_proyecto=@id_Personal_proyecto,id_personal=@id_personal,descripcion=@descripcion,fecha_registro=@fecha_registro WHERE id_proyectoDetalle=@id_proyectoDetalle";
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@id_proyectoDetalle", proyectoDetalle.id_proyectoDetalle);
                Comando.Parameters.AddWithValue("@id_proyecto", proyectoDetalle.id_proyecto);
                Comando.Parameters.AddWithValue("@id_cliente", proyectoDetalle.id_cliente);
                Comando.Parameters.AddWithValue("@id_responsable", proyectoDetalle.id_responsable);
                Comando.Parameters.AddWithValue("id_recurso", proyectoDetalle.id_recurso);
                Comando.Parameters.AddWithValue("@id_tarea", proyectoDetalle.id_tarea);
                Comando.Parameters.AddWithValue("@id_progreso", proyectoDetalle.id_progreso);
                Comando.Parameters.AddWithValue("@id_equipo", proyectoDetalle.id_equipo);
                Comando.Parameters.AddWithValue("@id_Personal_proyecto", proyectoDetalle.id_Personal_proyecto);
                Comando.Parameters.AddWithValue("@id_personal", proyectoDetalle.id_personal);
                Comando.Parameters.AddWithValue("@descripcion", proyectoDetalle.descripcion);
                Comando.Parameters.AddWithValue("@fecha_registro", proyectoDetalle.fecha_registro);
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
        public bool Eliminar(int proyectodetalleId)
        {
            bool eliminado = false;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "DELETE FROM ProyectoDetalle WHERE id_proyectoDetalle = @id_proyectoDetalle";
                Comando.Parameters.AddWithValue("@id_proyectoDetalle", proyectodetalleId);
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