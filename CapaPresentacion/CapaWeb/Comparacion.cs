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
    public partial class Comparacion : Form
    {
        public Comparacion()
        {
            InitializeComponent();
        }


        private DataTable grid1()
        {
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("Cantidad de cuotas", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("Monto total a pagar", typeof(Double));
            dt.Columns.Add(dc);

            dc = new DataColumn("Monto total de cuota", typeof(Double));
            dt.Columns.Add(dc);

            double porcentaje =1.03;

            for (int i = 1; i <= 6; i++)
            {
     
                double resultado = double.Parse(txtMontoAComparar.Text) * porcentaje; 
                double totalApagar= resultado / i;

                DataRow dr = dt.NewRow();

                dr[0] = i;
                dr[1] = Math.Round(resultado,2);//total a pagar
                dr[2] = Math.Round(totalApagar, 2);//total a pagar



                dt.Rows.Add(dr);//this will add the row at the end of the datatable
                porcentaje = porcentaje + 0.03;
            }

            return dt;
         
        }

        private DataTable grid2()
        {
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("Cantidad de cuotas", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("Monto total a pagar", typeof(Double));
            dt.Columns.Add(dc);

            dc = new DataColumn("Monto total de cuota", typeof(Double));
            dt.Columns.Add(dc);

            double porcentaje = 1.028;

            for (int i = 1; i <= 12; i++)
            {

                double resultado = double.Parse(txtMontoAComparar.Text) * porcentaje;
                double totalApagar = resultado / i;

                DataRow dr = dt.NewRow();

                dr[0] = i;
                dr[1] = Math.Round(resultado, 2);//total a pagar
                dr[2] = Math.Round(totalApagar, 2);//total a pagar



                dt.Rows.Add(dr);//this will add the row at the end of the datatable
                porcentaje = porcentaje + 0.028;
            }


            return dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMontoAComparar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            gridTarjeta1.DataSource = grid1();
            gridTarjeta2.DataSource = grid2();
        }
    }
}
