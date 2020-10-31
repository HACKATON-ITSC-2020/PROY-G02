using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonGrupo02.CapaNegocio
{
    class ConexionBBDD
    {
        //cadena de conexion
        static private string CadenaConexion = "Server=(local);Database=Hackaton; integrated security=true";

        //conexion a base de datos
        protected SqlConnection Conexion = new SqlConnection(CadenaConexion);
        
        
        //metodos para conectar y desconectar de la base de datos, si esta desconectado conecta y visceversa
        protected void Conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }

        }

        protected void Desconectar()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }

        }

    }
}
