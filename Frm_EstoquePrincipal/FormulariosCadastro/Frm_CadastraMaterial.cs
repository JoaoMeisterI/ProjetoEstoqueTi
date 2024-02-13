using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EstoqueTI
{
    
    public partial class Frm_CadastraMaterial : Form
    {
       
        public Frm_CadastraMaterial()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            //item = item.BuscarFicharioSQLREL(1);


            item.id = 2;
            item.nomeItem = "Computador";
            item.valorItem = "10000";
            item.fornecedor = "Pedrelli informática";
            item.observacao = "TESTE 2";

            item.nomeItem = "Computador Supra Bolado";

            item.ApagarFicharioSQLREL();





        }
    }
}
