using HackatonGrupo02.CapaDatos;
using HackatonGrupo02.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackatonGrupo02.CapaPresentacion.CapaWeb
{
    public partial class RegistroUsuario : Form
    {
        MetodosUsuario metUsuario = new MetodosUsuario();
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtNombre.Text, txtApellido.Text, txtDni.Text, txtUsuario.Text, txtClave.Text);
            metUsuario.AltaUsuario(usuario);
            this.Close();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
