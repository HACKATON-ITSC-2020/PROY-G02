using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackatonGrupo02.Modelo;

namespace HackatonGrupo02.CapaNegocio
{
    class MetodosTarjeta : ConexionBBDD
    {

        private SqlCommand Comando = new SqlCommand();

        //metodo para dar de alta en base de datos.
        public void AltaTarjeta(Tarjeta tarjeta)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "AltaTarjeta";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idTipoTarjeta", tarjeta.idTipoTarjeta);
            Comando.Parameters.AddWithValue("@nombre", tarjeta.nombre);
            Comando.Parameters.AddWithValue("@idBanco", tarjeta.idBanco);
            Comando.Parameters.AddWithValue("@idUsuario", tarjeta.idUsuario);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para dar de baja 
        public void BajaTarjeta(Tarjeta tarjeta)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "BajaTarjeta";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idTarjeta", tarjeta.idTarjeta);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para modificar 
        public void ModificarTarjeta(Tarjeta tarjeta)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "ModificarTarjeta";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idTipoTarjeta", tarjeta.idTipoTarjeta);
            Comando.Parameters.AddWithValue("@nombre", tarjeta.nombre);
            Comando.Parameters.AddWithValue("@idBanco", tarjeta.idBanco);
            Comando.Parameters.AddWithValue("@idUsuario", tarjeta.idUsuario);
            Comando.Parameters.AddWithValue("@idTarjeta", tarjeta.idTarjeta);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
