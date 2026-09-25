namespace FahrenheitParaCelsius
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
            this.CelsiusPFah = new System.Windows.Forms.RadioButton();
            this.FahPCelsius = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Celsius = new System.Windows.Forms.Label();
            this.Fahrenheit = new System.Windows.Forms.Label();
            this.Limpar = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CelsiusPFah
            // 
            this.CelsiusPFah.AutoSize = true;
            this.CelsiusPFah.Checked = true;
            this.CelsiusPFah.Location = new System.Drawing.Point(275, 53);
            this.CelsiusPFah.Name = "CelsiusPFah";
            this.CelsiusPFah.Size = new System.Drawing.Size(135, 17);
            this.CelsiusPFah.TabIndex = 0;
            this.CelsiusPFah.TabStop = true;
            this.CelsiusPFah.Text = "Celsius para Fahrenheit";
            this.CelsiusPFah.UseVisualStyleBackColor = true;
            // 
            // FahPCelsius
            // 
            this.FahPCelsius.AutoSize = true;
            this.FahPCelsius.Location = new System.Drawing.Point(275, 136);
            this.FahPCelsius.Name = "FahPCelsius";
            this.FahPCelsius.Size = new System.Drawing.Size(135, 17);
            this.FahPCelsius.TabIndex = 1;
            this.FahPCelsius.TabStop = true;
            this.FahPCelsius.Text = "Fahrenheit para Celsius";
            this.FahPCelsius.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Location = new System.Drawing.Point(61, 50);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(43, 13);
            this.Celsius.TabIndex = 4;
            this.Celsius.Text = "Celsius:";
            this.Celsius.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.AutoSize = true;
            this.Fahrenheit.Location = new System.Drawing.Point(61, 136);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(60, 13);
            this.Fahrenheit.TabIndex = 5;
            this.Fahrenheit.Text = "Fahrenheit:";
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(182, 176);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 6;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(287, 176);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 7;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 211);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FahPCelsius);
            this.Controls.Add(this.CelsiusPFah);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CelsiusPFah;
        private System.Windows.Forms.RadioButton FahPCelsius;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Celsius;
        private System.Windows.Forms.Label Fahrenheit;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Calcular;
    }
}

