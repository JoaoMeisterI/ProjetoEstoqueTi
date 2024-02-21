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
using static EstoqueTI.Classes.Recebe;

namespace EstoqueTI
{
    public partial class Frm_Recebe : Form
    {
        public Frm_Recebe()
        {
            InitializeComponent();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {


            try
            {
                FuncoesUteis.Funcoes FuncoesUteis = new Funcoes();
                int ID = FuncoesUteis.BuscarFicharioId("dbo.recebe");

                Unit u = new Unit();
                u.id = ID += 1;
                u.item = cb_item.Text;
                u.valor = float.Parse(txt_valor.Text);
                u.fornecedor = cb_fornecedor.Text;
                u.motivo = rb_motivo.Text;
                u.data = dt_date.Text;
                u.quantidade = nd_quantidade.Text;
                u.ValidaClasse();
                u.IncluirFicharioSQLREL();






                MessageBox.Show($"Item: {cb_item.Text} recebido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Recebe Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Recebe_Load(object sender, EventArgs e)
        {
            Unit.PreencherComboBoxItens(cb_item);
            Unit.PreencherComboBoxFornecedores(cb_fornecedor);
        }
    }
}
