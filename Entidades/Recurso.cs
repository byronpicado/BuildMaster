using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recurso

    {

        public string id_recurso { get; set; }

        public string tipo { get; set; }

        public string descripcion { get; set; }

        public decimal costo { get; set; }

        //Constructor sin parametros
        public Recurso() { }
        //Constructor con parametros
        public Recurso(string idRecurso, string tipo, string descripcion, decimal costo)

        {

            this.id_recurso = idRecurso;

            this.tipo = tipo;

            this.descripcion = descripcion;

            this.costo = costo;

        }

    }
}
