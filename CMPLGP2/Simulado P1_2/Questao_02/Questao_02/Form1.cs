using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questao_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txbCapital.Text = "0.0";
            txbTxJuros.Text = "0.0";
            txbNPeriodo.Text = "0.0";
            txbJuros.Text = "0.0";
            txbMontante.Text = "0.0";

            rdbJuroSimples.Checked = true;

        }

        private void rdbJuroSimples_CheckedChanged(object sender, EventArgs e)
        {
            txbTipoDoJuros.Text = "Simples";
        }

        private void txbJurosCompostos_CheckedChanged(object sender, EventArgs e)
        {
            txbTipoDoJuros.Text = "Composto";
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txbCapital.Clear();
            txbTxJuros.Clear();
            txbNPeriodo.Clear();
            txbJuros.Clear();
            txbMontante.Clear();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double C = double.Parse(txbCapital.Text);
            double i = double.Parse(txbTxJuros.Text);
            double n = double.Parse(txbNPeriodo.Text);

            double J, M;

            if (rdbJuroSimples.Checked == true)
            {
                 J = C * i * n;
                 M = C + J;
            }
            else
            {
                 M = C * Math.Pow((1 + i), n);
                 J = M - C;
            }

            txbJuros.Text = J.ToString();
            txbMontante.Text = M.ToString();
        }
    }
}
