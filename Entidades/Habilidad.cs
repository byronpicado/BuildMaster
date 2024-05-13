using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habilidad

    {

        public string id_habilidad { get; set; }

        public string descripcion { get; set; }
        
        //Constructor sin parametros
        public Habilidad() { }


        //Constructor con parametros
        public Habilidad(string idHabilidad, string descripcion)

        {

            this.id_habilidad = idHabilidad;

            this.descripcion = descripcion;

        }

    }
}
