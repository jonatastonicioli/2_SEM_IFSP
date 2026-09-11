namespace Ex_02
{
    public partial class FrmMain : Form
    {
        private int cont = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCliques_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //incrementa o total de cliques
            cont = cont + 1;
            //atualiza o label usado para exibir o total de cliques
            lblCliques.Text = cont.ToString();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cont = 0;

        }
    }
}
