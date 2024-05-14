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
    internal class ProgresoCN
    {
        private ProgresoCD progresoCD = new ProgresoCD();
        public DataTable ObtenerProgreso()
        {
            DataTable tabla = new DataTable();
            tabla = progresoCD.ObtenerProgreso();
            return tabla;
        }
        //pasar a capa de datos
        public bool Insertar(Progreso progreso)
        {
            return progresoCD.Insertar(progreso);
        }
        public bool Editar(Progreso progreso)
        {
            return progresoCD.Editar(progreso);
        }

        public bool Eliminar(int progresoId)
        {
            return progresoCD.Eliminar(progresoId);
            return false;
        }
    }
}