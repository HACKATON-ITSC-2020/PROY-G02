using FontAwesome.Sharp;
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
    public partial class Tarjetas : Form
    {
        private string tarjetaCredito = "";
        private string tarjetaDebito = "";
        private string[] arrayCredito = new string[2];

        public Tarjetas()
        {
            InitializeComponent();
        }

        private void btn_debVisa_Click(object sender, EventArgs e)
        {
            tarjetaDebito = "VISA DEBITO";
            if (MessageBox.Show($"Esta por ligar {tarjetaDebito} a su cuenta. Esta seguro?", "CONFIRMAR DEBITO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //TODO agregar la tarjeta de debito a la cuenta
                lblDebitoUsuario.Text = $"La tarjeta de debito activa en tu cuenta es: {tarjetaDebito}";
            }
            else
            {
                MessageBox.Show($"No se agrego {tarjetaDebito} a su cuenta");
            }
        }

        private void btn_debMaster_Click(object sender, EventArgs e)
        {
            tarjetaDebito = "MASTERCARD DEBITO";
            if (MessageBox.Show($"Esta por ligar {tarjetaDebito} a su cuenta. Esta seguro?", "CONFIRMAR DEBITO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //TODO agregar la tarjeta de debito a la cuenta
                lblDebitoUsuario.Text = $"La tarjeta de debito activa en tu cuenta es: {tarjetaDebito}";
            }
            else
            {
                MessageBox.Show($"No se agrego {tarjetaDebito} a su cuenta");
            }
        }

        private void btn_credVisa_Click(object sender, EventArgs e)
        {
            tarjetaCredito = "VISA CREDITO";
            if (MessageBox.Show($"Esta por ligar {tarjetaCredito} a su cuenta. Esta seguro?", "CONFIRMAR DEBITO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                agregarTarjeta(tarjetaCredito);
                //TODO agregar la tarjeta de credito a la cuenta
                lblCreditoUsuario.Text = $"La tarjeta de credito activa en tu cuenta es: {tarjetaCredito}";
            }
            else
            {
                MessageBox.Show($"No se agrego {tarjetaCredito} a su cuenta");
            }
        }

        private void btn_credMaster_Click(object sender, EventArgs e)
        {
            tarjetaCredito = "MASTERCARD CREDITO";
            if (MessageBox.Show($"Esta por ligar {tarjetaCredito} a su cuenta. Esta seguro?", "CONFIRMAR DEBITO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //TODO agregar la tarjeta de credito a la cuenta
                lblCreditoUsuario.Text = $"La tarjeta de credito activa en tu cuenta es: {tarjetaCredito}";
            }
            else
            {
                MessageBox.Show($"No se agrego {tarjetaCredito} a su cuenta");
            }
        }

        private void btn_credDiscov_Click(object sender, EventArgs e)
        {
            tarjetaCredito = "DISCOVER CREDITO";
            if (MessageBox.Show($"Esta por ligar {tarjetaCredito} a su cuenta. Esta seguro?", "CONFIRMAR DEBITO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //TODO agregar la tarjeta de credito a la cuenta
                lblCreditoUsuario.Text = $"La tarjeta de credito activa en tu cuenta es: {tarjetaCredito}";
            }
            else
            {
                MessageBox.Show($"No se agrego {tarjetaCredito} a su cuenta");
            }
        }

        private void btn_credStripe_Click(object sender, EventArgs e)
        {
            tarjetaCredito = "STRIPE CREDITO";
            if (MessageBox.Show($"Esta por ligar {tarjetaCredito} a su cuenta. Esta seguro?", "CONFIRMAR DEBITO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //TODO agregar la tarjeta de credito a la cuenta
                lblCreditoUsuario.Text = $"La tarjeta de credito activa en tu cuenta es: {tarjetaCredito}";
            }
            else
            {
                MessageBox.Show($"No se agrego {tarjetaCredito} a su cuenta");
            }
        }

        private string agregarTarjeta(string tarjeta)
        {
            arrayCredito[0] = tarjeta;

            if (arrayCredito[0] != null)
            {
                arrayCredito[1] = tarjeta;
            }
            if (arrayCredito[1] != null)
            {
                arrayCredito[0] = tarjeta;
            }

            return arrayCredito.ToString();
        }

    }
}
