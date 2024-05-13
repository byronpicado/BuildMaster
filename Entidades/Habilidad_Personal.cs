using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habilidad_Personal

    {

        public string id_habilidad_personal { get; set; }



        public string id_personal { get; set; }

        public string Id_habilidad { get; set; }

        //Constructor sin parametros
        public Habilidad_Personal() { }  
        //Constructor con parametros
        public Habilidad_Personal(string idHabilidadPersonal, string idPersonalProyecto, string idProyecto, string idCliente, string idResponsable, string idPersonal, string idHabilidad)

        {

            this.id_habilidad_personal = idHabilidadPersonal;


            this.id_personal = idPersonal;

            this.Id_habilidad = idHabilidad;

        }

    }
}
