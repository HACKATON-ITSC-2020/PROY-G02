using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using HackatonGrupo02.CapaDatos;
using HackatonGrupo02.CapaNegocio;
using HackatonGrupo02.CapaPresentacion.CapaWeb;
using HackatonGrupo02.Forms;

namespace HackatonGrupo02
{
    public partial class FormPrincipal : Form
    {
        private IconButton botonSeleccionado;
        private Panel bordeBoton;
        private Form formHijoActual;
        MetodosUsuario metUsuario = new MetodosUsuario();
        MetodosCajaDeAhorro metCaja = new MetodosCajaDeAhorro();
        public static Usuario usuarioNuevo;

        //FORM LOAD
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lbFecha.Text = "Fecha " + DateTime.Now.ToString("dd-MM-yyyy");
            DesactivarPanelPrincipal();
          
            IniciarTextBox();

            

        }

        public FormPrincipal()
        {
            InitializeComponent();
            bordeBoton = new Panel();
            bordeBoton.Size = new Size(7, 60);
            panelMenu.Controls.Add(bordeBoton);
        }

        #region EVENTOS BOTONES
        private struct ColoresRGB
        {
            public static Color color1 = Color.FromArgb(183, 124, 237);
            public static Color color2 = Color.FromArgb(242, 118, 176);
            public static Color color3 = Color.FromArgb(254, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(26, 160, 249);
        }

        //activar y desactivar efecto botones
        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                botonSeleccionado = (IconButton)senderBtn;
                botonSeleccionado.BackColor = Color.FromArgb(37, 36, 81);
                botonSeleccionado.ForeColor = color;
                botonSeleccionado.TextAlign = ContentAlignment.MiddleCenter;
                botonSeleccionado.IconColor = color;
                botonSeleccionado.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonSeleccionado.ImageAlign = ContentAlignment.MiddleRight;
                //borde boton
                bordeBoton.BackColor = color;
                bordeBoton.Location = new Point(0, botonSeleccionado.Location.Y);
                bordeBoton.Visible = true;
                bordeBoton.BringToFront();
            }
        }
        private void ActivarBotones()
        {
            btn_depositar.Enabled = true;
            btn_comparacion.Enabled = true;
            btn_rendimiento.Enabled = true;
            btn_tarjetas.Enabled = true;
            btn_movimientos.Enabled = true;
            iconButton2.Enabled = true;
        }
        private void DesactivarBoton()
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.BackColor = Color.FromArgb(31, 30, 68);
                botonSeleccionado.ForeColor = Color.Transparent;
                botonSeleccionado.TextAlign = ContentAlignment.MiddleLeft;
                botonSeleccionado.IconColor = Color.White;
                botonSeleccionado.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonSeleccionado.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //abrir forms hijos
        private void abrirFormHijo(Form formHijo)
        {
            if (formHijoActual != null)
            {
                formHijoActual.Close();
            }
            formHijoActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formHijo);
            panelEscritorio.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();

        }

        //botones
        private void btn_depositar_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.color1);
            abrirFormHijo(new Movimientos());
        }
        private void btn_transferir_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.color2);
            abrirFormHijo(new Construccion());
        }
        private void btn_extraer_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.color3);
            abrirFormHijo(new Construccion());
        }
        private void btn_comparacion_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.color4);
            abrirFormHijo(new Comparacion());
        }
        private void btn_rendimiento_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.color5);
            abrirFormHijo(new Construccion());
        }
        private void btn_movimientos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.color6);
            abrirFormHijo(new Construccion());
        }
        private void btn_tarjetas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.color1);
            abrirFormHijo(new Tarjetas());
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.color3);
            abrirFormHijo(new Construccion());
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region METODOS
        //metodo para generar efecto en los textbox para ingresar texto y que cambie de color.
        private void IniciarTextBox()
        {
            MetodosGenericos.Init(txtUsuario, "Ingrese su usuario");
            MetodosGenericos.Init(txtPass, "Password");
        }


        #endregion

        // imagen logo
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DesactivarBoton();
            panelEscritorio.BringToFront();
        }

        //login usuario
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario(txtUsuario.Text, txtPass.Text);
            if (metUsuario.VerificarPassword(usuario))
            {
                usuarioNuevo = metUsuario.CrearUsuario(txtUsuario.Text);

                CajaDeAhorro cajaDeAhorro = metCaja.CrearCaja(usuarioNuevo.dni);

                lblBienvenido.Text = "BIENVENIDO: " + usuarioNuevo.nombre.ToUpper();
                lblSaldo.Text = "Tu saldo es: " + cajaDeAhorro.saldo;

                ActivarBotones();
            }
            else
                return;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new RegistroUsuario());

        }

        //panel con info del usuario
       private void DesactivarPanelPrincipal()
        {
            lblBienvenido.Text = "";
            //panelCuentas.Visible = false;
            lblSaldo.Text = "";
            lblCA.Text = "";
        }

        private void ActivarPanelPrincipal()
        {
            //panelCuentas.Visible = true;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            
        }

    
    }
}