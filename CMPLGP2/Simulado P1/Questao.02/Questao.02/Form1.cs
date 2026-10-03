using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questao._02
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txbCapital.Clear();
            txbTXJuros.Clear();
            txbPeriodo.Clear();
            txbJuro.Clear();
            txbMontante.Clear();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            txbCapital.Text = "0";
            txbTXJuros.Text = "0";
            txbPeriodo.Text = "0";
            txbJuro.Text = "0";
            txbMontante.Text = "0";

            rbSimples.Checked = true;
        }

        private void JurosSimples_CheckedChanged(object sender, EventArgs e)
        {
            //txbTipoJuro.Text = "Juros Simples";
            if (rbSimples.Checked) txbTipoJuro.Text = "Juros Simples";
        }

        private void JurosCompostos_CheckedChanged(object sender, EventArgs e)
        {
            //txbTipoJuro.Text = "Juros Compostos";
            if (rbCompostos.Checked) txbTipoJuro.Text = "Juros Compostos";
        }

        private void Calcular_Click(object sender, EventArgs e)
        {

            double C = double.Parse(txbCapital.Text);
            double i = double.Parse(txbTXJuros.Text) / 100 ;
            double n = double.Parse(txbPeriodo.Text);

            

            double M = 0.0;
            double J = 0.0;

            if (rbCompostos.Checked)

            {
                M = C * Math.Pow((1 + i), n);
                J = M - C;
            }

            if (rbSimples.Checked)
            {
                J = C * i * n;
                M = C + J;
            }

            //txbJuro.Text = J.ToString();
            //txbMontante.Text = M.ToString();

            txbJuro.Text = String.Format("{0:C}", J);
            txbMontante.Text = String.Format("{0:C}", M);

        }
    }
}
