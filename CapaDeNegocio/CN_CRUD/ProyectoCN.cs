using CapaDeDatos.CRUD;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio.CN_CRUD
{
    public class ProyectoCN
    {
        private ProyectoCD proyectoCD = new ProyectoCD();
        public DataTable ObtenerProyecto()
        {
            DataTable tabla = new DataTable();
            tabla = proyectoCD.ObtenerProyecto();
            return tabla;
        }
        //pasar a capa de datos
        public bool Insertar(Proyecto proyecto)
        {
            return proyectoCD.Insertar(proyecto);
        }
        public bool Editar(Proyecto proyecto)
        {
            return proyectoCD.Editar(proyecto);
        }

        public bool Eliminar(int proyectoId)
        {
            return proyectoCD.Eliminar(proyectoId);
            return false;
        }
    }
}