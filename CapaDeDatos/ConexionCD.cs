using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    internal class ConexionCD
    {
   
            private SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-CAKRKLJ\\SQLEXPRESS; Database = BuildMasterDB;Integrated Security = True");

            public SqlConnection AbrirConexion()
            {
                if (Conexion.State == System.Data.ConnectionState.Closed)
                {
                    Conexion.Open();


                }
                return Conexion;
            }
            //metodo cerrar conexion

            public SqlConnection CerrarConexion()
            {
                if (Conexion.State == System.Data.ConnectionState.Open)
                {
                    Conexion.Close();



                }
                return Conexion;
            }
        }
    }
    
