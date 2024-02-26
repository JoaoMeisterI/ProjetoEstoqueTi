using EstoqueTI.FuncoesUteis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EstoqueTI.Classes.CentroCusto;

namespace EstoqueTI.FormulariosCadastro
{
    public partial class Frm_CadastroCC : Form
    {
        public Frm_CadastroCC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                FuncoesUteis.Funcoes FuncoesUteis = new Funcoes();
              

                Unit u = new Unit();
               
                u.codigo = txt_codigo.Text;
                u.descricao = txt_descricao.Text;
                u.orcamento = float.Parse(txt_orcamento.Text);
                u.ValidaClasse();
                u.IncluirFicharioSQLREL();

                MessageBox.Show($"Centro de Custo: {txt_descricao.Text} cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Centro de Custo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
