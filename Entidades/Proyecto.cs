﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proyecto

    {

        public string id_proyecto { get; set; }

        public string id_cliente { get; set; }

        public string id_responsable { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public DateTime fecha_inicio { get; set; }

        public DateTime fecha_fin { get; set; }

        public string Estado { get; set; }

        //Cosntructor sin parametros
        public Proyecto() { }   


        //Constructor con parametros
        public Proyecto(string idProyecto, string idCliente, string idResponsable, string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, string estado)

        {

            IdProyecto = idProyecto;

            IdCliente = idCliente;

            IdResponsable = idResponsable;

            Nombre = nombre;

            Descripcion = descripcion;

            FechaInicio = fechaInicio;

            FechaFin = fechaFin;

            Estado = estado;

        }

    }
}