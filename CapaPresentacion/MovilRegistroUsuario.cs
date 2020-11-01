using HackatonGrupo02.CapaNegocio;
using HackatonGrupo02.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackatonGrupo02.CapaPresentacion
{
    public partial class MovilRegistroUsuario : Form
    {
        MetodosUsuario metUsuario = new MetodosUsuario();

        public MovilRegistroUsuario()
        {
            InitializeComponent();
        }

        private void MovilRegistroUsuario_Load(object sender, EventArgs e)
        {
            MetodosGenericos.Init(txtNombre, "Ingrese un nombre");
            MetodosGenericos.Init(txtApellido, "Ingrese un apellido");
            MetodosGenericos.Init(txtDni, "Ingrese un DNI");
            MetodosGenericos.Init(txtUsuario, "Ingrese un nombre de usuario");
            MetodosGenericos.Init(txtPassword, "Ingrese un password");

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            VistaMovilInicio inicio = new VistaMovilInicio();
            inicio.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtNombre.Text, txtApellido.Text, txtDni.Text,txtUsuario.Text, txtPassword.Text);
            metUsuario.AltaUsuario(usuario);
            VistaMovilInicio movil = new VistaMovilInicio();
            movil.Show();
            this.Close();
        }
    }
}
