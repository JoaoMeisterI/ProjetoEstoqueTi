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
using static EstoqueTI.Classes.fornecedor;

namespace EstoqueTI.FormulariosCadastro
{
    public partial class Frm_CadastroFornecedor : Form
    {
        public Frm_CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
               

                Unit u = new Unit();
       
                u.cnpj = txt_cnpj.Text;
                u.nome = txt_nome.Text;
                u.contato = txt_contato.Text;
                u.ValidaClasse();
                u.IncluirFicharioSQLREL();

                MessageBox.Show($"Fornecedor {txt_nome.Text} cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Centro de Custo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
