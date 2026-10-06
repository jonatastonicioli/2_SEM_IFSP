namespace Questao_02
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCapital = new System.Windows.Forms.TextBox();
            this.txbTxJuros = new System.Windows.Forms.TextBox();
            this.txbNPeriodo = new System.Windows.Forms.TextBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.rdbJuroSimples = new System.Windows.Forms.RadioButton();
            this.txbJurosCompostos = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTipoDoJuros = new System.Windows.Forms.TextBox();
            this.txbJuros = new System.Windows.Forms.TextBox();
            this.txbMontante = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbNPeriodo);
            this.groupBox1.Controls.Add(this.txbTxJuros);
            this.groupBox1.Controls.Add(this.txbCapital);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbJurosCompostos);
            this.groupBox2.Controls.Add(this.rdbJuroSimples);
            this.groupBox2.Location = new System.Drawing.Point(196, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Calcular);
            this.groupBox3.Controls.Add(this.Limpar);
            this.groupBox3.Location = new System.Drawing.Point(196, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 97);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txbMontante);
            this.groupBox4.Controls.Add(this.txbJuros);
            this.groupBox4.Controls.Add(this.txbTipoDoJuros);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(13, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 97);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tx de Juros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "N Periodos:";
            // 
            // txbCapital
            // 
            this.txbCapital.Location = new System.Drawing.Point(77, 32);
            this.txbCapital.Name = "txbCapital";
            this.txbCapital.Size = new System.Drawing.Size(68, 20);
            this.txbCapital.TabIndex = 3;
            // 
            // txbTxJuros
            // 
            this.txbTxJuros.Location = new System.Drawing.Point(77, 69);
            this.txbTxJuros.Name = "txbTxJuros";
            this.txbTxJuros.Size = new System.Drawing.Size(68, 20);
            this.txbTxJuros.TabIndex = 4;
            // 
            // txbNPeriodo
            // 
            this.txbNPeriodo.Location = new System.Drawing.Point(77, 104);
            this.txbNPeriodo.Name = "txbNPeriodo";
            this.txbNPeriodo.Size = new System.Drawing.Size(68, 20);
            this.txbNPeriodo.TabIndex = 5;
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(21, 20);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(100, 23);
            this.Limpar.TabIndex = 0;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(21, 63);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(100, 23);
            this.Calcular.TabIndex = 1;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // rdbJuroSimples
            // 
            this.rdbJuroSimples.AutoSize = true;
            this.rdbJuroSimples.Location = new System.Drawing.Point(21, 34);
            this.rdbJuroSimples.Name = "rdbJuroSimples";
            this.rdbJuroSimples.Size = new System.Drawing.Size(90, 17);
            this.rdbJuroSimples.TabIndex = 0;
            this.rdbJuroSimples.TabStop = true;
            this.rdbJuroSimples.Text = "Juros SImples";
            this.rdbJuroSimples.UseVisualStyleBackColor = true;
            this.rdbJuroSimples.CheckedChanged += new System.EventHandler(this.rdbJuroSimples_CheckedChanged);
            // 
            // txbJurosCompostos
            // 
            this.txbJurosCompostos.AutoSize = true;
            this.txbJurosCompostos.Location = new System.Drawing.Point(21, 71);
            this.txbJurosCompostos.Name = "txbJurosCompostos";
            this.txbJurosCompostos.Size = new System.Drawing.Size(105, 17);
            this.txbJurosCompostos.TabIndex = 1;
            this.txbJurosCompostos.TabStop = true;
            this.txbJurosCompostos.Text = "Juros Compostos";
            this.txbJurosCompostos.UseVisualStyleBackColor = true;
            this.txbJurosCompostos.CheckedChanged += new System.EventHandler(this.txbJurosCompostos_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo do Juros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Juros:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Montante:";
            // 
            // txbTipoDoJuros
            // 
            this.txbTipoDoJuros.Enabled = false;
            this.txbTipoDoJuros.Location = new System.Drawing.Point(77, 20);
            this.txbTipoDoJuros.Name = "txbTipoDoJuros";
            this.txbTipoDoJuros.Size = new System.Drawing.Size(68, 20);
            this.txbTipoDoJuros.TabIndex = 3;
            // 
            // txbJuros
            // 
            this.txbJuros.Enabled = false;
            this.txbJuros.Location = new System.Drawing.Point(77, 47);
            this.txbJuros.Name = "txbJuros";
            this.txbJuros.Size = new System.Drawing.Size(68, 20);
            this.txbJuros.TabIndex = 4;
            // 
            // txbMontante
            // 
            this.txbMontante.Enabled = false;
            this.txbMontante.Location = new System.Drawing.Point(77, 71);
            this.txbMontante.Name = "txbMontante";
            this.txbMontante.Size = new System.Drawing.Size(68, 20);
            this.txbMontante.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 271);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbNPeriodo;
        private System.Windows.Forms.TextBox txbTxJuros;
        private System.Windows.Forms.TextBox txbCapital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton txbJurosCompostos;
        private System.Windows.Forms.RadioButton rdbJuroSimples;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txbMontante;
        private System.Windows.Forms.TextBox txbJuros;
        private System.Windows.Forms.TextBox txbTipoDoJuros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

