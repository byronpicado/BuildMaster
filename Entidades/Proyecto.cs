using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proyecto

    {

        public int id_proyecto { get; set; }

        public string codigo { get; set; }

        public int id_cliente { get; set; }
        public int id_responsable { get; set; }
        public string Cliente { get; set; }
        public string Responsable { get; set; }
        public string Progreso { get; set; }


        public string descripcion { get; set; }

        public DateTime fecha_inicio { get; set; }

        public DateTime fecha_fin { get; set; }

        public string Estado { get; set; }

        //Cosntructor sin parametros
        public Proyecto(int proyectoid) { }


        //Constructor con parametros
        public Proyecto(int idProyecto, string codigo, int id_cliente, int id_responsable,string Cliente,string Responsable,string Progreso, string descripcion, DateTime fechaInicio, DateTime fechaFin, string estado)

        {

            this.id_proyecto = idProyecto;
            this.codigo = codigo;
            this.id_cliente = id_cliente;
            this.id_responsable = id_responsable;
            this.Cliente = Cliente;
            this.Responsable = Responsable;
            this.Progreso = Progreso;
         
            this.descripcion = descripcion;
            this.fecha_inicio = fechaInicio;
            this.fecha_fin = fechaFin;
            Estado = estado;

        }

    }
}
