using CapaDeDatos.CRUD;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDeNegocio.CN_CRUD
{

    //Obtner desde la capa de datos
    public class ClienteCN
    {


            private ClienteCD clienteCD = new ClienteCD();
            public DataTable ObtenerCliente()
            {
                DataTable tabla = new DataTable();
                tabla = clienteCD.ObtenerCliente();
                return tabla;
            }
            //pasar a capa de datos
            public bool Insertar(Entidades.Cliente cliente)
            {
                return clienteCD.Insertar(cliente);
            }
            public bool Editar(Entidades.Cliente cliente)
            {
                return clienteCD.Editar(cliente);
            }

            public bool Eliminar(int clienteId)
            {
                return clienteCD.Eliminar(clienteId);
                return false;
            }
        }
    }
