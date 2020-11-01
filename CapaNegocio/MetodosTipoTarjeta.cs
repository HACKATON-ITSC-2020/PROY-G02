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
    class MetodosTipoTarjeta : ConexionBBDD
    {

        private SqlCommand Comando = new SqlCommand();

        //metodo para dar de alta en base de datos.
        public void AltaTipoTarjeta(TipoTarjeta tipoTarjeta)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "AltaTipoTarjeta";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@nombre", tipoTarjeta.nombre);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para dar de baja 
        public void BajaTipoTarjeta(TipoTarjeta tipoTarjeta)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "BajaTipoTarjeta";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idTipoTarjeta", tipoTarjeta.idTipoTarjeta);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para modificar 
        public void ModificarTarjeta(TipoTarjeta tipoTarjeta)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "ModificarTipoTarjeta";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idTipoTarjeta", tipoTarjeta.idTipoTarjeta);
            Comando.Parameters.AddWithValue("@nombre", tipoTarjeta.nombre);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
