using HackatonGrupo02.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackatonGrupo02.CapaNegocio
{
    class MetodosUsuario : ConexionBBDD //extiende de conexion de bbdd para utilizar los metodos de dicha clase.
    {
        private SqlCommand Comando = new SqlCommand();
        SqlDataReader LeerFilas;
        MetodosCajaDeAhorro metCajaAhorro = new MetodosCajaDeAhorro();
        MetodosCuentaCorriente metCuentaCorriente = new MetodosCuentaCorriente();


        //metodo para dar de alta en base de datos.
        public void AltaUsuario(Usuario usuario) 
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "AltaUsuario";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@nombre", usuario.nombre);
            Comando.Parameters.AddWithValue("@apellido", usuario.apellido);
            Comando.Parameters.AddWithValue("@dni", usuario.dni);
            Comando.Parameters.AddWithValue("@usuario", usuario.usuario1);
            Comando.Parameters.AddWithValue("@clave", usuario.clave);
            Comando.ExecuteNonQuery();
            Conexion.Close();

            CajaDeAhorro caja = new CajaDeAhorro(usuario.dni,70000,1);
            metCajaAhorro.AltaCajaDeAhorro(caja);
            CuentaCorriente ctaCte = new CuentaCorriente(usuario.dni,0,1);
            metCuentaCorriente.AltaCuentaCorriente(ctaCte);

            MessageBox.Show("Insertado con exito!");
        }
      
        //metodo para dar de baja al usuario
        public void BajaUsuario(Usuario usuario)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "BajaUsuario";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idUsuario", usuario.idUsuario);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para modificar usuario
        public void ModificacionUsuario(Usuario usuario)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "ModificarUsuario";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@nombre", usuario.nombre);
            Comando.Parameters.AddWithValue("@apellido", usuario.apellido);
            Comando.Parameters.AddWithValue("@dni", usuario.dni);
            Comando.Parameters.AddWithValue("@usuario", usuario.usuario1);
            Comando.Parameters.AddWithValue("@clave", usuario.clave);
            Comando.Parameters.AddWithValue("@idUsuario", usuario.idUsuario);
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        //metodo para validar existencia

        public Boolean VerificarPassword(Usuario usuario)
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "ValidarUserYpass";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@usuario", usuario.usuario1);
            Comando.Parameters.AddWithValue("@clave", usuario.clave);
            LeerFilas = Comando.ExecuteReader();
            if (LeerFilas.Read())
            {
                LeerFilas.Close();
                Conexion.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Error en usuario o contraseña");
                LeerFilas.Close();
                Conexion.Close();
                return false;
            }

        }

        //metodo para crear un usuario utilizando para hacer un get
        public Usuario CrearUsuario(string usuarioNombre)
        {
            Usuario us = new Usuario();

            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "LeerUsuario";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@usuario", usuarioNombre);
            LeerFilas = Comando.ExecuteReader();

            while (LeerFilas.Read())
            {
                us.nombre= LeerFilas.GetString(1);
                us.apellido = LeerFilas.GetString(2);
                us.dni = LeerFilas.GetString(3);
                us.usuario1 = LeerFilas.GetString(4);
                us.clave = LeerFilas.GetString(5);
                
            }
            LeerFilas.Close();
            Conexion.Close();

            return us;
        }



    }
}
