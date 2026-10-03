namespace Questao._02
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.Montante = new System.Windows.Forms.Label();
            this.ValorJuros = new System.Windows.Forms.Label();
            this.TipoJuro = new System.Windows.Forms.Label();
            this.txbMontante = new System.Windows.Forms.TextBox();
            this.txbJuro = new System.Windows.Forms.TextBox();
            this.txbTipoJuro = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbCompostos = new System.Windows.Forms.RadioButton();
            this.rbSimples = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Limpar = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CapInicial = new System.Windows.Forms.Label();
            this.TxJuros = new System.Windows.Forms.Label();
            this.NumPeriodos = new System.Windows.Forms.Label();
            this.txbCapital = new System.Windows.Forms.TextBox();
            this.txbTXJuros = new System.Windows.Forms.TextBox();
            this.txbPeriodo = new System.Windows.Forms.TextBox();
            this.alo = new System.Windows.Forms.Panel();
            this.valoresEntrada = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.alo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Montante);
            this.panel2.Controls.Add(this.ValorJuros);
            this.panel2.Controls.Add(this.TipoJuro);
            this.panel2.Controls.Add(this.txbMontante);
            this.panel2.Controls.Add(this.txbJuro);
            this.panel2.Controls.Add(this.txbTipoJuro);
            this.panel2.Location = new System.Drawing.Point(12, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 100);
            this.panel2.TabIndex = 1;
            // 
            // Montante
            // 
            this.Montante.AutoSize = true;
            this.Montante.Location = new System.Drawing.Point(25, 69);
            this.Montante.Name = "Montante";
            this.Montante.Size = new System.Drawing.Size(52, 13);
            this.Montante.TabIndex = 5;
            this.Montante.Text = "Montante";
            // 
            // ValorJuros
            // 
            this.ValorJuros.AutoSize = true;
            this.ValorJuros.Location = new System.Drawing.Point(25, 42);
            this.ValorJuros.Name = "ValorJuros";
            this.ValorJuros.Size = new System.Drawing.Size(32, 13);
            this.ValorJuros.TabIndex = 4;
            this.ValorJuros.Text = "Juros";
            // 
            // TipoJuro
            // 
            this.TipoJuro.AutoSize = true;
            this.TipoJuro.Location = new System.Drawing.Point(25, 15);
            this.TipoJuro.Name = "TipoJuro";
            this.TipoJuro.Size = new System.Drawing.Size(71, 13);
            this.TipoJuro.TabIndex = 3;
            this.TipoJuro.Text = "Tipo do Juros";
            // 
            // txbMontante
            // 
            this.txbMontante.Enabled = false;
            this.txbMontante.Location = new System.Drawing.Point(103, 69);
            this.txbMontante.Name = "txbMontante";
            this.txbMontante.Size = new System.Drawing.Size(100, 20);
            this.txbMontante.TabIndex = 2;
            // 
            // txbJuro
            // 
            this.txbJuro.Enabled = false;
            this.txbJuro.Location = new System.Drawing.Point(103, 42);
            this.txbJuro.Name = "txbJuro";
            this.txbJuro.Size = new System.Drawing.Size(100, 20);
            this.txbJuro.TabIndex = 1;
            // 
            // txbTipoJuro
            // 
            this.txbTipoJuro.Enabled = false;
            this.txbTipoJuro.Location = new System.Drawing.Point(103, 15);
            this.txbTipoJuro.Name = "txbTipoJuro";
            this.txbTipoJuro.Size = new System.Drawing.Size(100, 20);
            this.txbTipoJuro.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbCompostos);
            this.panel3.Controls.Add(this.rbSimples);
            this.panel3.Location = new System.Drawing.Point(269, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 100);
            this.panel3.TabIndex = 2;
            // 
            // rbCompostos
            // 
            this.rbCompostos.AutoSize = true;
            this.rbCompostos.Location = new System.Drawing.Point(32, 59);
            this.rbCompostos.Name = "rbCompostos";
            this.rbCompostos.Size = new System.Drawing.Size(105, 17);
            this.rbCompostos.TabIndex = 1;
            this.rbCompostos.TabStop = true;
            this.rbCompostos.Text = "Juros Compostos";
            this.rbCompostos.UseVisualStyleBackColor = true;
            this.rbCompostos.CheckedChanged += new System.EventHandler(this.JurosCompostos_CheckedChanged);
            // 
            // rbSimples
            // 
            this.rbSimples.AutoSize = true;
            this.rbSimples.Location = new System.Drawing.Point(32, 17);
            this.rbSimples.Name = "rbSimples";
            this.rbSimples.Size = new System.Drawing.Size(89, 17);
            this.rbSimples.TabIndex = 0;
            this.rbSimples.TabStop = true;
            this.rbSimples.Text = "Juros Simples";
            this.rbSimples.UseVisualStyleBackColor = true;
            this.rbSimples.CheckedChanged += new System.EventHandler(this.JurosSimples_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Limpar);
            this.panel4.Controls.Add(this.Calcular);
            this.panel4.Location = new System.Drawing.Point(269, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 100);
            this.panel4.TabIndex = 1;
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(32, 3);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(129, 46);
            this.Limpar.TabIndex = 1;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(32, 55);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(129, 42);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipos de Juros";
            // 
            // CapInicial
            // 
            this.CapInicial.AutoSize = true;
            this.CapInicial.Location = new System.Drawing.Point(14, 15);
            this.CapInicial.Name = "CapInicial";
            this.CapInicial.Size = new System.Drawing.Size(69, 13);
            this.CapInicial.TabIndex = 0;
            this.CapInicial.Text = "Capital Inicial";
            // 
            // TxJuros
            // 
            this.TxJuros.AutoSize = true;
            this.TxJuros.Location = new System.Drawing.Point(3, 45);
            this.TxJuros.Name = "TxJuros";
            this.TxJuros.Size = new System.Drawing.Size(94, 13);
            this.TxJuros.TabIndex = 1;
            this.TxJuros.Text = "Taxa de Juros (%):";
            // 
            // NumPeriodos
            // 
            this.NumPeriodos.AutoSize = true;
            this.NumPeriodos.Location = new System.Drawing.Point(3, 75);
            this.NumPeriodos.Name = "NumPeriodos";
            this.NumPeriodos.Size = new System.Drawing.Size(105, 13);
            this.NumPeriodos.TabIndex = 2;
            this.NumPeriodos.Text = "Número de Períodos";
            // 
            // txbCapital
            // 
            this.txbCapital.Location = new System.Drawing.Point(114, 14);
            this.txbCapital.Name = "txbCapital";
            this.txbCapital.Size = new System.Drawing.Size(100, 20);
            this.txbCapital.TabIndex = 3;
            // 
            // txbTXJuros
            // 
            this.txbTXJuros.Location = new System.Drawing.Point(114, 45);
            this.txbTXJuros.Name = "txbTXJuros";
            this.txbTXJuros.Size = new System.Drawing.Size(100, 20);
            this.txbTXJuros.TabIndex = 4;
            // 
            // txbPeriodo
            // 
            this.txbPeriodo.Location = new System.Drawing.Point(114, 72);
            this.txbPeriodo.Name = "txbPeriodo";
            this.txbPeriodo.Size = new System.Drawing.Size(100, 20);
            this.txbPeriodo.TabIndex = 5;
            // 
            // alo
            // 
            this.alo.Controls.Add(this.txbPeriodo);
            this.alo.Controls.Add(this.txbTXJuros);
            this.alo.Controls.Add(this.txbCapital);
            this.alo.Controls.Add(this.NumPeriodos);
            this.alo.Controls.Add(this.TxJuros);
            this.alo.Controls.Add(this.CapInicial);
            this.alo.Location = new System.Drawing.Point(12, 35);
            this.alo.Name = "alo";
            this.alo.Size = new System.Drawing.Size(223, 100);
            this.alo.TabIndex = 0;
            // 
            // valoresEntrada
            // 
            this.valoresEntrada.AutoSize = true;
            this.valoresEntrada.Location = new System.Drawing.Point(18, 27);
            this.valoresEntrada.Name = "valoresEntrada";
            this.valoresEntrada.Size = new System.Drawing.Size(97, 13);
            this.valoresEntrada.TabIndex = 3;
            this.valoresEntrada.Text = "Valores de Entrada";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valoresEntrada);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.alo);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.alo.ResumeLayout(false);
            this.alo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label Montante;
        private System.Windows.Forms.Label ValorJuros;
        private System.Windows.Forms.Label TipoJuro;
        private System.Windows.Forms.TextBox txbMontante;
        private System.Windows.Forms.TextBox txbJuro;
        private System.Windows.Forms.TextBox txbTipoJuro;
        private System.Windows.Forms.RadioButton rbCompostos;
        private System.Windows.Forms.RadioButton rbSimples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CapInicial;
        private System.Windows.Forms.Label TxJuros;
        private System.Windows.Forms.Label NumPeriodos;
        private System.Windows.Forms.TextBox txbCapital;
        private System.Windows.Forms.TextBox txbTXJuros;
        private System.Windows.Forms.TextBox txbPeriodo;
        private System.Windows.Forms.Panel alo;
        private System.Windows.Forms.Label valoresEntrada;
    }
}

