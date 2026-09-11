namespace Ex_02
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMensagem = new Label();
            lblCliques = new Label();
            btnClique = new Button();
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.Blue;
            lblMensagem.Location = new Point(10, 8);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(137, 19);
            lblMensagem.TabIndex = 0;
            lblMensagem.Text = "Total de Cliques:";
            lblMensagem.Click += label1_Click;
            // 
            // lblCliques
            // 
            lblCliques.AutoSize = true;
            lblCliques.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliques.ForeColor = Color.Red;
            lblCliques.Location = new Point(156, 9);
            lblCliques.Name = "lblCliques";
            lblCliques.Size = new Size(17, 18);
            lblCliques.TabIndex = 1;
            lblCliques.Text = "0";
            lblCliques.Click += lblCliques_Click;
            // 
            // btnClique
            // 
            btnClique.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClique.Location = new Point(45, 64);
            btnClique.Name = "btnClique";
            btnClique.Size = new Size(140, 40);
            btnClique.TabIndex = 2;
            btnClique.Text = " Pressione-me !";
            btnClique.UseVisualStyleBackColor = true;
            btnClique.Click += button1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 126);
            Controls.Add(btnClique);
            Controls.Add(lblCliques);
            Controls.Add(lblMensagem);
            Name = "FrmMain";
            Text = "Cliques";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensagem;
        private Label lblCliques;
        private Button btnClique;
    }
}
