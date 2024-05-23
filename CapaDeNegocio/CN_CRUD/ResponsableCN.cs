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
    public class ResponsableCN
    {
        private ResponsableCD responsableCD = new ResponsableCD();
        public DataTable ObtenerResponsable()
        {
            DataTable tabla = new DataTable();
            tabla = responsableCD.ObtenerResponsable();
            return tabla;
        }
        //pasar a capa de datos
        public bool Insertar(Responsable responsable)
        {
            return responsableCD.Insertar(responsable);
        }
        public bool Editar(Responsable responsable)
        {
            return responsableCD.Editar(responsable);
        }

        public bool Eliminar(int responsableId)
        {
            return responsableCD.Eliminar(responsableId);
            return false;
        }
    }
}
