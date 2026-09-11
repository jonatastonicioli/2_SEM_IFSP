using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDividendo.Clear();
            txtDivisor.Clear();
            txtQuociente.Clear();
            txtResto.Clear();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //recupera o texto que foi digitado nas caixas de texto
            int dividendo = int.Parse(txtDividendo.Text);
            int divisor = int.Parse(txtDivisor.Text);
            //calcula o quociente e o resto da divisão
            int quociente = (dividendo / divisor);
            int resto = dividendo % divisor;
            //atualiza as caixas de textos com o quociente e resto da divisão
            txtQuociente.Text = quociente.ToString();
            txtResto.Text = resto.ToString();

        }
    }
}
