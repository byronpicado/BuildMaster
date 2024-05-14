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
    internal class TareaCN
    {
        private TareaCD tareaCD = new TareaCD();
        public DataTable ObtenerTarea()
        {
            DataTable tabla = new DataTable();
            tabla = tareaCD.ObtenerTarea();
            return tabla;
        }
        //pasar a capa de datos
        public bool Insertar(Tarea tarea)
        {
            return tareaCD.Insertar(tarea);
        }
        public bool Editar(Tarea tarea)
        {
            return tareaCD.Editar(tarea);
        }

        public bool Eliminar(int tareaId)
        {
            return tareaCD.Eliminar(tareaId);
            return false;
        }
    }
}
