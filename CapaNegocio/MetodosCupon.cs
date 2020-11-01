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
    class MetodosCupon : ConexionBBDD
    {

        private SqlCommand Comando = new SqlCommand();

        //metodo para dar de alta en base de datos.
        public void AltaCupon(Cupon cupon)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "AltaCupon";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@porcentaje", cupon.porcentajeDescuento);
            Comando.Parameters.AddWithValue("@idTarjeta", cupon.idTarjeta);
            Comando.ExecuteNonQuery();
            Conexion.Close();

        }

        //metodo para dar de baja 
        public void BajaCupon(Cupon cupon)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "BajaCupon";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idCupon", cupon.idCupon);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para modificar 
        public void ModificarCupon(Cupon cupon)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "ModificarCupon";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@porcentaje", cupon.porcentajeDescuento);
            Comando.Parameters.AddWithValue("@idTarjeta", cupon.idTarjeta);
            Comando.Parameters.AddWithValue("@idCupon", cupon.idCupon);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
