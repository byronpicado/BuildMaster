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


        public string descripcion { get; set; }

        public DateTime fecha_registro { get; set; }


        //Csntructor sin parametros
        public ProyectoDetalle() { }
        //Constructor con parametros
        public ProyectoDetalle(string idProyectoDetalle, string descripcion, DateTime fechaRegistro)

        {

            this.id_proyectoDetalle = idProyectoDetalle;


            this.descripcion = descripcion;

            this.fecha_registro = fechaRegistro;

        }

    }
}
