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
using static EstoqueTI.Classes.Transfere;

namespace EstoqueTI.FormulariosMovimento
{
    public partial class Frm_Transfere : Form
    {
        public Frm_Transfere()
        {
            InitializeComponent();
        }

        private void Frm_Transfere_Load(object sender, EventArgs e)
        {
            Unit.PreencherComboBoxItens(cb_item);
            Unit.PreencherComboBoxFornecedores(cb_fornecedor);
            Unit.PreencherComboBoxCentroCusto(cb_cc);
        }

        private void btn_Transfere_Click(object sender, EventArgs e)
        {

            try
            {


                Unit u = new Unit();
                string item1 = cb_item.Text;
                u.item = Unit.BuscaIdItem(item1);
                u.valor = float.Parse(txt_valor.Text);
                string fornecedor1 = cb_fornecedor.Text;
                u.fornecedor = Unit.BuscaIdFornecedor(fornecedor1);
                u.motivo = rb_motivo.Text;
                u.data = dt_date.Text;
                u.quantidade = int.Parse((nd_quantidade.Text));
                string cc = cb_cc.Text;
                u.contacontabil = Unit.BuscaIdCentroCusto(cc);
                u.local = txt_local.Text;

                u.ValidaClasse();

                //FAZER MÉTODO QUE RETIRA DO ESTOQUE ESSE ADICIONA
                //Unit.AlteraQuantidade(u.item, u.quantidade);

                u.IncluirFicharioSQLREL();







                MessageBox.Show($"Item: {cb_item.Text} transferido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Recebe Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

