using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MantenimientoEquipo

    {

        public string id_mantenimiento_Equipo { get; set; }

        public string id_mantenimiento { get; set; }

        public string id_equipo { get; set; }

        //Constructor sin parametros
        public MantenimientoEquipo() { }
        //Constructor con parametros
        public MantenimientoEquipo(string idMantenimientoEquipo, string idMantenimiento, string idEquipo)

        {

            this.id_mantenimiento_Equipo = idMantenimientoEquipo;

            this.id_mantenimiento = idMantenimiento;

            this.id_equipo = idEquipo;

        }

    }
}
