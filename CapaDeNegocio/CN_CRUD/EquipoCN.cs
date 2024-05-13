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
    internal class EquipoCN
    {
        private EquipoCD equipoCD = new EquipoCD();
        public DataTable ObetenerEquipo()
        {
            DataTable tabla = new DataTable();
            tabla = equipoCD.ObtenerEquipo();
            return tabla;
        }
        //pasar a capa de datos
        public bool Insertar(Equipo equipo)
        {
            return equipoCD.Insertar(equipo);
        }
        public bool Editar(Equipo equipo)
        {
            return equipoCD.Editar(equipo);
        }

        public bool Eliminar(int equipoId)
        {
            return equipoCD.Eliminar(equipoId);
            return false;
        }
    }
}
