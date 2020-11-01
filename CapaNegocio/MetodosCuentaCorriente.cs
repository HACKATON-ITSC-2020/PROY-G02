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
    class MetodosCuentaCorriente : ConexionBBDD
    {
        private SqlCommand Comando = new SqlCommand();


        //metodo para dar de alta en base de datos.
        public void AltaCuentaCorriente(CuentaCorriente cuentaCorriente)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "AltaCuentaCorriente";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@numero", cuentaCorriente.numero);
            Comando.Parameters.AddWithValue("@saldo", cuentaCorriente.saldo);
            Comando.Parameters.AddWithValue("@idBanco", cuentaCorriente.idBanco);
            Comando.ExecuteNonQuery();
            Conexion.Close();

        }

        //metodo para dar de baja 
        public void BajaCuentaCorriente(CuentaCorriente cuentaCorriente)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "BajaCuentaCorriente";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idCuentaCorriente", cuentaCorriente.idCuentaCorriente);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para modificar 
        public void ModificarCuentaCorriente(CuentaCorriente cuentaCorriente)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "ModificarCuentaCorriente";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@numero", cuentaCorriente.numero);
            Comando.Parameters.AddWithValue("@saldo", cuentaCorriente.saldo);
            Comando.Parameters.AddWithValue("@idBanco", cuentaCorriente.idBanco);
            Comando.Parameters.AddWithValue("@idCuentaCorriente", cuentaCorriente.idCuentaCorriente);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
