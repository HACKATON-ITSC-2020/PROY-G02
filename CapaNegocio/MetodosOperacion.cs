using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackatonGrupo02.CapaDatos;

namespace HackatonGrupo02.CapaNegocio
{
    class MetodosOperacion : ConexionBBDD
    {
        SqlDataReader LeerFilas;
        private SqlCommand Comando = new SqlCommand();
        MetodosCajaDeAhorro metCaja = new MetodosCajaDeAhorro();
        


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
            Comando.Parameters.AddWithValue("@destinatario", operacion.Destinatario);
            Comando.Parameters.AddWithValue("@dni", operacion.Dni);
            Comando.Parameters.AddWithValue("@detalle", operacion.Detalle);
            Comando.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Insertado con exito");

            CajaDeAhorro caja = new CajaDeAhorro(FormPrincipal.usuarioNuevo.dni, decimal.Parse(operacion.montoOperacion.ToString()));
            
            metCaja.ModificarCajaDeAhorro(caja);

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

        //metodo para leer y llenar grilla
        public DataTable LeerDepositos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "LeerDepositos";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();

            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.Close();
            return Tabla;




        }

    }
}
