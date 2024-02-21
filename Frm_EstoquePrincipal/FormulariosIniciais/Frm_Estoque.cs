//Usa objetos de banco de dados
using EstoqueTI;
using EstoqueTI.FormulariosCadastro;
using EstoqueTI.FormulariosIniciais;
using System.Data.SqlClient;

namespace Frm_EstoquePrincipal

{
    public partial class Frm_Estoque : Form
    {
        public Frm_Estoque()
        {
            InitializeComponent();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Frm_CadastraItem frm = new Frm_CadastraItem();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_CadastraUsuario frm = new Frm_CadastraUsuario();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_CadastroCC frm = new Frm_CadastroCC();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_CadastroFornecedor frm = new Frm_CadastroFornecedor();
            frm.Show();
        }

        private void receberMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Recebe frm = new Frm_Recebe();
            frm.Show();
        }
    }
}
