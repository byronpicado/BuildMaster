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
    internal class ResponsableCN
    {
        private ResponsableCD responsableCD = new ResponsableCD();
        public DataTable ObtenerRecurso()
        {
            DataTable tabla = new DataTable();
            tabla = responsableCD.ObtenerResponsable();
            return tabla;
        }
        //pasar a capa de datos
        public bool Insertar(Personal personal)
        {
            return personalCD.Insertar(personal);
        }
        public bool Editar(Personal personal)
        {
            return personalCD.Editar(personal);
        }

        public bool Eliminar(int personalId)
        {
            return personalCD.Eliminar(personalId);
            return false;
        }
    }
}
