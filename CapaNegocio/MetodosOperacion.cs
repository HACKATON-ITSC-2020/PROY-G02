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
    class MetodosOperacion : ConexionBBDD
    {
        private SqlCommand Comando = new SqlCommand();

        //metodo para dar de alta en base de datos.
        public void AltaOperacion(Operacion operacion)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "AltaOperacion";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idTipoOperacion", operacion.idTipoOperacion);
            Comando.Parameters.AddWithValue("@fechaOperacion", operacion.fechaOperacion);
            Comando.Parameters.AddWithValue("@montoOperacion", operacion.montoOperacion);
            Comando.ExecuteNonQuery();
            Conexion.Close();
  
        }

        //metodo para dar de baja 
        public void BajaOperacion(Operacion operacion)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "BajaOperacion";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idOperacion", operacion.idOperacion);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para modificar 
        public void ModificarOperacion(Operacion operacion)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "ModificarOperacion";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idTipoOperacion", operacion.idTipoOperacion);
            Comando.Parameters.AddWithValue("@fechaOperacion", operacion.fechaOperacion);
            Comando.Parameters.AddWithValue("@montoOperacion", operacion.montoOperacion);
            Comando.Parameters.AddWithValue("@idOperacion", operacion.idOperacion);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
