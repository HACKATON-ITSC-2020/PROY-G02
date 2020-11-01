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
    class MetodosCajaDeAhorro : ConexionBBDD
    {

        private SqlCommand Comando = new SqlCommand();


        //metodo para dar de alta en base de datos.
        public void AltaCajaDeAhorro(CajaDeAhorro caja)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "AltaCajaDeAhorro";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@numeroCaja", caja.numero);
            Comando.Parameters.AddWithValue("@fechaVencimiento", caja.fechaVencimiento);
            Comando.Parameters.AddWithValue("@saldo", caja.saldo);
            Comando.Parameters.AddWithValue("@idBanco", caja.idBanco);
            
            Comando.ExecuteNonQuery();
            Conexion.Close();


        }

        //metodo para dar de baja 
        public void BajaCajaDeAhorro(CajaDeAhorro caja)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "BajaCajaDeAhorro";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idCajaAhorro", caja.idCajaAhorro);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para modificar 
        public void ModificarCajaDeAhorro(CajaDeAhorro caja)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "ModificarCajaDeAhorro";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@numeroCaja", caja.numero);
            Comando.Parameters.AddWithValue("@fechaVencimiento", caja.fechaVencimiento);
            Comando.Parameters.AddWithValue("@saldo", caja.saldo);
            Comando.Parameters.AddWithValue("@idBanco", caja.idBanco);
            Comando.Parameters.AddWithValue("@idCajaAhorro", caja.idCajaAhorro);

            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

    }
}
