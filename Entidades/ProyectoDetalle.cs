using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProyectoDetalle

    {

        public string id_proyectoDetalle { get; set; }

        public string id_proyecto { get; set; }

        public string id_cliente { get; set; }

        public string id_responsable { get; set; }

        public string id_recurso { get; set; }

        public string id_tarea { get; set; }

        public string id_progreso { get; set; }

        public string id_equipo { get; set; }

        public string descripcion { get; set; }

        public DateTime fecha_registro { get; set; }

        public string id_Personal_proyecto { get; set; }

        public string id_personal{ get; set; }

        //Csntructor sin parametros
        public ProyectoDetalle() { }
        //Constructor con parametros
        public ProyectoDetalle(string idProyectoDetalle, string idProyecto, string idCliente, string idResponsable, string idRecurso, string idTarea, string idProgreso, string idEquipo, string descripcion, DateTime fechaRegistro, string id_Personal_proyecto, string id_personal)

        {

            this.id_proyectoDetalle = idProyectoDetalle;

            this.id_proyecto = idProyecto;

            this.id_cliente = idCliente;

            this.id_responsable = idResponsable;

            this.id_recurso = idRecurso;

            this.id_tarea = idTarea;

            this.id_progreso = idProgreso;

            this.id_equipo = idEquipo;

            this.descripcion = descripcion;

            this.fecha_registro = fechaRegistro;
            this.id_Personal_proyecto = id_Personal_proyecto;
            this.id_personal = id_personal;
        }

    }
}
