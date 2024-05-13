using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Personal_Proyecto

    {

        public string id_Personal_proyecto { get; set; }

        public string id_proyecto { get; set; }

        public string id_cliente { get; set; }

        public string id_responsable { get; set; }

        public string id_personal { get; set; }

        //Constructor sin parametros
        public Personal_Proyecto() { }
        //Constructor con parametros
        public Personal_Proyecto(string idPersonalProyecto, string idProyecto, string idCliente, string idResponsable, string idPersonal)

        {

            this.id_Personal_proyecto = idPersonalProyecto;

            this.id_proyecto = idProyecto;

            this.id_cliente = idCliente;

            this.id_responsable = idResponsable;

            this.id_personal = idPersonal;

        }

    }
}
