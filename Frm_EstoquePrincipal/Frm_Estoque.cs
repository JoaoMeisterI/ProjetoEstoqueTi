//Usa objetos de banco de dados
using EstoqueTI;
using EstoqueTI.FormulariosCadastro;
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
            frm_CadastroCC frm = new frm_CadastroCC();
            frm.Show();
        }
    }
}
