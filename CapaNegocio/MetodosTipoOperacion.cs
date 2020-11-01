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
    class MetodosTipoOperacion : ConexionBBDD
    {

        private SqlCommand Comando = new SqlCommand();

        //metodo para dar de alta en base de datos.
        public void AltaTipoOperacion(TipoOperacion tipoOperacion)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "AltaTipoOperacion";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@nombre", tipoOperacion.nombre);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para dar de baja 
        public void BajaTipoOperacion(TipoOperacion tipoOperacion)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "BajaTipoOperacion";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idTipoOperacion", tipoOperacion.idTipoOperacion);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para modificar 
        public void ModificarTipoOperacion(TipoOperacion tipoOperacion)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "ModificarTipoOperacion";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idTipoOperacion", tipoOperacion.idTipoOperacion);
            Comando.Parameters.AddWithValue("@nombre", tipoOperacion.nombre);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
