﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mantenimiento

    {

        public string id_mantenimiento { get; set; }

        public DateTime fecha_mantenimiento { get; set; }

        public string descripcion { get; set; }

        //Constructor sin parametros
        public Mantenimiento() { }
        //Constructor con parametros
        public Mantenimiento(string idMantenimiento, DateTime fechaMantenimiento, string descripcion)

        {

            this.id_mantenimiento = idMantenimiento;

            this.fecha_mantenimiento = fechaMantenimiento;

            this.descripcion = descripcion;

        }

    }
}
