using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackatonGrupo02.CapaDatos;

namespace HackatonGrupo02.CapaNegocio
{
    class MetodosCajaDeAhorro : ConexionBBDD
    {

        private SqlCommand Comando = new SqlCommand();
        SqlDataReader LeerFilas;

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
            Comando.Parameters.AddWithValue("@saldo", caja.saldo);
            
            

            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para crear un usuario utilizando para hacer un get
        public CajaDeAhorro CrearCaja(string numero)
        {
            CajaDeAhorro ca = new CajaDeAhorro();
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "LeerCaja";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@numero", numero);
            LeerFilas = Comando.ExecuteReader();

            while (LeerFilas.Read())
            {
                ca.idCajaAhorro = LeerFilas.GetInt32(0);
                ca.numero = LeerFilas.GetString(1);
                ca.saldo = LeerFilas.GetDecimal(3);
                ca.idBanco = LeerFilas.GetInt32(4);

            }
            LeerFilas.Close();
            Conexion.Close();

            return ca;
        }
    }
}
