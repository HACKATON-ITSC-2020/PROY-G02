using HackatonGrupo02.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonGrupo02.CapaNegocio
{
    class MetodosBanco : ConexionBBDD
    {
        private SqlCommand Comando = new SqlCommand();


        //metodo para dar de alta en base de datos.
        public void AltaBanco(Banco banco)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "AltaBanco";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@nombre", banco.nombre);

            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para dar de baja al banco
        public void BajaBanco(Banco banco)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "BajaBanco";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idBanco", banco.idBanco);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para modificar banco
        public void ModificarBanco(Banco banco)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "ModificarBanco";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@nombre", banco.nombre);
            Comando.Parameters.AddWithValue("@idBanco", banco.idBanco);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }



    }
}
