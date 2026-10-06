namespace Questao_02__CentParaPolegadas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbCenti = new System.Windows.Forms.TextBox();
            this.txbMedida = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rdbCentPPolegadas = new System.Windows.Forms.RadioButton();
            this.rdbCentimetroPPes = new System.Windows.Forms.RadioButton();
            this.lblMedida = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Centímetro";
            // 
            // txbCenti
            // 
            this.txbCenti.Location = new System.Drawing.Point(84, 16);
            this.txbCenti.Name = "txbCenti";
            this.txbCenti.Size = new System.Drawing.Size(100, 20);
            this.txbCenti.TabIndex = 2;
            this.txbCenti.Text = "3";
            // 
            // txbMedida
            // 
            this.txbMedida.Enabled = false;
            this.txbMedida.Location = new System.Drawing.Point(84, 42);
            this.txbMedida.Name = "txbMedida";
            this.txbMedida.Size = new System.Drawing.Size(100, 20);
            this.txbMedida.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(8, 98);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 33);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rdbCentPPolegadas
            // 
            this.rdbCentPPolegadas.AutoSize = true;
            this.rdbCentPPolegadas.Location = new System.Drawing.Point(16, 19);
            this.rdbCentPPolegadas.Name = "rdbCentPPolegadas";
            this.rdbCentPPolegadas.Size = new System.Drawing.Size(149, 17);
            this.rdbCentPPolegadas.TabIndex = 0;
            this.rdbCentPPolegadas.TabStop = true;
            this.rdbCentPPolegadas.Text = "Centímetro para Polegada";
            this.rdbCentPPolegadas.UseVisualStyleBackColor = true;
            this.rdbCentPPolegadas.CheckedChanged += new System.EventHandler(this.rdbCentPPolegadas_CheckedChanged);
            // 
            // rdbCentimetroPPes
            // 
            this.rdbCentimetroPPes.AutoSize = true;
            this.rdbCentimetroPPes.Location = new System.Drawing.Point(16, 63);
            this.rdbCentimetroPPes.Name = "rdbCentimetroPPes";
            this.rdbCentimetroPPes.Size = new System.Drawing.Size(122, 17);
            this.rdbCentimetroPPes.TabIndex = 1;
            this.rdbCentimetroPPes.TabStop = true;
            this.rdbCentimetroPPes.Text = "Centímetro para Pés";
            this.rdbCentimetroPPes.UseVisualStyleBackColor = true;
            this.rdbCentimetroPPes.CheckedChanged += new System.EventHandler(this.rdbCentimetroPPes_CheckedChanged);
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(18, 45);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(57, 13);
            this.lblMedida.TabIndex = 1;
            this.lblMedida.Tag = "";
            this.lblMedida.Text = "Polegadas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMedida);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbCenti);
            this.groupBox1.Controls.Add(this.txbMedida);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbCentimetroPPes);
            this.groupBox2.Controls.Add(this.rdbCentPPolegadas);
            this.groupBox2.Location = new System.Drawing.Point(224, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 119);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 137);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Calculadora";
            this.Text = "Conversor de Medidas";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCenti;
        private System.Windows.Forms.TextBox txbMedida;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rdbCentPPolegadas;
        private System.Windows.Forms.RadioButton rdbCentimetroPPes;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

