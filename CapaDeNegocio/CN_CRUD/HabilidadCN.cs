using CapaDeDatos.CRUD;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio.CN_CRUD
{
    internal class HabilidadCN
    {
       
            private HabilidadCD habilidadCD = new HabilidadCD();
            public DataTable ObtenerHabilidad()
            {
                DataTable tabla = new DataTable();
                tabla = habilidadCD.ObtenerHabilidad();
                return tabla;
            }
        //pasar a capa de datos
        public bool Insertar(Habilidad habilidad)
        {
            return habilidadCD.Insertar(habilidad);
            }
            public bool Editar(Habilidad habilidad)
            {
                return habilidadCD.Editar(habilidad);
            }

            public bool Eliminar(int habilidad_personalId)
            {
                return habilidadCD.Eliminar(habilidad_personalId);
                return false;
            }
        }
    }