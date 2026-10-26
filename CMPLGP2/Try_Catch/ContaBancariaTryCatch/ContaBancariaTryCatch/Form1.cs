using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancariaTryCatch
{
    public partial class Form1 : Form
    {
        private ContaBancaria conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conta = new ContaBancaria();

            txbSaldo.Text = conta.saldo().ToString();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbDeposito.Checked = true)
            {
                conta.deposito()
            }
            
        }
    }
}
