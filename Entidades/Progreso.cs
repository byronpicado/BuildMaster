using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Progreso

    {

        public string id_progreso { get; set; }

        public string descripcion { get; set; }

        public DateTime fecha_registro { get; set; }

        //Constructor sin parametros
        public Progreso() { }
        //Constructor con parametros
        public Progreso(string idProgreso, string descripcion, DateTime fechaRegistro)

        {

            this.id_progreso = idProgreso;

            this.descripcion = descripcion;

            this.fecha_registro = fechaRegistro;

        }

    }
}
