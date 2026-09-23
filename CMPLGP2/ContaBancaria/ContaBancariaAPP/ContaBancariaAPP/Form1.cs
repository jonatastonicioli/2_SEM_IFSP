using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancariaAPP
{
    public partial class FrmMain : Form
    {
        private ContaBancaria conta;

        public FrmMain() // construtor da janela
        {
            InitializeComponent();

            conta = new ContaBancaria();

            txtSaldo.Text = conta.getSaldo().ToString(); // construtor mostando na caixa de texto txtSaldo o valor de 100
                                                         //toString para converter o double em string
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            double valor;

            valor = double.Parse(txtValor.Text); //acessa o valor escrito no txtValor 
            //e tranforma para double (antes era string)


            if (rbDeposito.Checked == true) // verifica se o radioButton deposito
            //esta checked e se tiver faz o deposito acessando o obejto e chamando 
            //o metodo saque e passando como parametro o valor 
            {
                bool rs = conta.deposito(valor);

                if (rs == true)
                {
                    MessageBox.Show("Depósito Realizado");
                }
                else
                {
                    MessageBox.Show("Falha no depósito");
                }

                txtSaldo.Text = conta.getSaldo().ToString(); // atualizando o textBox com o novo valor depositado
            }

            if(rbSaque.Checked == true)
            {
                bool rs1 = conta.saque(valor);

                if (rs1 == true)
                {
                    MessageBox.Show("Saque Realizado");
                }
                else
                {
                    MessageBox.Show("Falha no Saque");
                }

                txtSaldo.Text = conta.getSaldo().ToString(); // atualizando o textBox com o novo valor depositado
            }
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
