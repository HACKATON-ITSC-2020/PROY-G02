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

namespace HackatonGrupo02.Forms
{
    public partial class Movimientos : Form
    {
        MetodosOperacion metOperacion = new MetodosOperacion();


        public Movimientos()
        {
            InitializeComponent();
        }

        private void Movimientos_Load(object sender, EventArgs e)
        {
            ActualizarGridDepositos();

        }


        private void ActualizarGridDepositos()
        {
            gridDepositos.DataSource = metOperacion.LeerDepositos();
            gridDepositos.Columns[0].Visible = false;
            gridDepositos.Columns[1].Visible = false;
            gridDepositos.Columns[2].HeaderText = "Fecha de operacion";
            gridDepositos.Columns[3].HeaderText = "Monto";
            gridDepositos.Columns[4].HeaderText = "Destino de deposito";
            gridDepositos.Columns[5].Visible = false;
            gridDepositos.Columns[6].HeaderText = "Detaller de la operacion";

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion(1,DateTime.Now, decimal.Parse(txtMonto.Text.Replace(".",",")),txtDestinatario.Text,txtDniDestinatario.Text,txtDetalle.Text);
           
            metOperacion.AltaOperacion(op);
            ActualizarGridDepositos();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

   
    }
}
