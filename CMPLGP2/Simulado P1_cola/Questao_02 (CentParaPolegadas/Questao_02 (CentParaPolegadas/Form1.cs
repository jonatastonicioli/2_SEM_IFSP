using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questao_02__CentParaPolegadas
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            txbCenti.Text = "0.0";
            txbMedida.Text = "0.0 ";

            rdbCentPPolegadas.Checked = true;
        }

        private void rdbCentPPolegadas_CheckedChanged(object sender, EventArgs e)
        {
            lblMedida.Text = "Polegada";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cent = double.Parse(txbCenti.Text);

            if (rdbCentimetroPPes.Checked == true)
            {
           
                double pes = cent / 30.48;
                txbMedida.Text = String.Format("{0:F2}",pes);
            }

            if(rdbCentPPolegadas.Checked == true)
            {
                
                double pol = cent / 2.54;
                txbMedida.Text = String.Format("{0:F2}", pol);

            }
        }

        private void rdbCentimetroPPes_CheckedChanged(object sender, EventArgs e)
        {
            lblMedida.Text = "Pés";
        }
    }
}
