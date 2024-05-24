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
    public class MantenimientoCN
    {
        private MantenimientoCD mantenimientoCD = new MantenimientoCD();
        public DataTable ObtenerMantenimiento()
        {
            DataTable tabla = new DataTable();
            tabla = mantenimientoCD.ObtenerMantenimiento();
            return tabla;
        }
        //pasar a capa de datos
        public bool Insertar(Mantenimiento mantenimiento)
        {
            return mantenimientoCD.Insertar(mantenimiento);
        }
        public bool Editar(Mantenimiento mantenimiento)
        {
            return mantenimientoCD.Editar(mantenimiento);
        }

        public bool Eliminar(int mantenimientoId)
        {
            return mantenimientoCD.Eliminar(mantenimientoId);
            return false;
        }
    }
}
