using CapaDeDatos.CRUD;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio.CN_CRUD
{
    public class RecursoCN
    {
        private RecursoCD recursoCD = new RecursoCD();
        public DataTable ObtenerRecurso()
        {
            DataTable tabla = new DataTable();
            tabla = recursoCD.ObtenerRecurso();  
            return tabla;
        }
        //pasar a capa de datos
        public bool Insertar(Recurso recurso)
        {
            return recursoCD.Insertar(recurso);
        }
        public bool Editar(Recurso recurso)
        {
            return recursoCD.Editar(recurso);
        }

        public bool Eliminar(int recursoId)
        {
            return recursoCD.Eliminar(recursoId);
            return false;
        }
    }
}
