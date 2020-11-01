using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackatonGrupo02.CapaNegocio;
using HackatonGrupo02.CapaPresentacion;
using HackatonGrupo02.CapaDatos;

namespace HackatonGrupo02.CapaPresentacion
{
    public partial class VistaMovilInicio : Form
    {
        
        MetodosUsuario metUsuario = new MetodosUsuario();
        

        public VistaMovilInicio()
        {
            InitializeComponent();
        }
        #region EVENTOS LABELS
        private void lblCerrar_MouseEnter(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.Red;
        }

        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.Black;
        }

        private void lblCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void lblRegistrar_Click(object sender, EventArgs e)
        {
            MovilRegistroUsuario registro = new MovilRegistroUsuario();
            registro.Show();
            this.Hide();
        }

        private void lblRegistrar_MouseEnter(object sender, EventArgs e)
        {
            lblRegistrar.ForeColor = Color.Red;
        }

        private void lblRegistrar_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrar.ForeColor = Color.Black;
        }
        #endregion

        private void VistaMovilInicio_Load(object sender, EventArgs e)
        {
            

            MetodosGenericos.Init(txtUsuario, "Ingrese su usuario");
            MetodosGenericos.Init(txtPass, "Ingrese su Password");

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            Usuario usuario = new Usuario(txtUsuario.Text, txtPass.Text);
            if (metUsuario.VerificarPassword(usuario))
            {
                PrincipalMovil principal = new PrincipalMovil();
                principal.Show();
                this.Hide();

            }
            else
               return;
                
        }
        
    }
}
