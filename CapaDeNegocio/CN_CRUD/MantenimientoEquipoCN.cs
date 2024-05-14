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
    internal class MantenimientoEquipoCN
    {
        private MantenimientoEquipoCD mantenimientoEquipoCD = new MantenimientoEquipoCD();
        public DataTable ObtenerMantenimientoEquipo()
        {
            DataTable tabla = new DataTable();
            tabla = mantenimientoEquipoCD.ObtenerMantenimientoEquipo();
            return tabla;
        }
        //pasar a capa de datos
        public bool Insertar(MantenimientoEquipo mantenimientoEquipo)
        {
            return mantenimientoEquipoCD.Insertar(mantenimientoEquipo);
        }
        public bool Editar(MantenimientoEquipo mantenimientoEquipo)
        {
            return mantenimientoEquipoCD.Editar(mantenimientoEquipo);
        }

        public bool Eliminar(int mantenimientoequipoId)
        {
            return mantenimientoEquipoCD.Eliminar(mantenimientoequipoId);
            return false;
        }
    }
}