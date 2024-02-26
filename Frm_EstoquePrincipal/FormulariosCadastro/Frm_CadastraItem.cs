using EstoqueTI.FuncoesUteis;
using Microsoft.VisualBasic.ApplicationServices;
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
using static EstoqueTI.Classes.Item;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace EstoqueTI
{

    public partial class Frm_CadastraItem : Form
    {

        public Frm_CadastraItem()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
               

                Unit u = new Unit();
              
                u.nomeItem = txt_item.Text;
                u.categoria = cb_categoria.Text;
                u.observacao = txt_observacao.Text;
                u.ValidaClasse();
                u.IncluirFicharioSQLREL();

                MessageBox.Show($"Item {txt_item.Text} cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
