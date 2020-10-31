﻿using HackatonGrupo02.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonGrupo02.CapaNegocio
{
    class MetodosUsuario : ConexionBBDD //extiende de conexion de bbdd para utilizar los metodos de dicha clase.
    {
        private SqlCommand Comando = new SqlCommand();

        SqlDataReader LeerFilas;

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







    }
}
