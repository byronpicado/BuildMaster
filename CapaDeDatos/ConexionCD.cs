﻿using System;
using System.Collections.Generic;
 using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class ConexionCD
    {
   
            private SqlConnection Conexion = new SqlConnection("Data Source =DESKTOP-CAKRKLJ\\SQLEXPRESS; Database = BuildMasterDB;Integrated Security=True");

        //Metodo para abrir la conexion
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();

            return Conexion;
        }

        //Metodo cerrar la conexion

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();

            return Conexion;
        }


    }
}
