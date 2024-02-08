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
            item.id = 1;
            item.nomeItem = "ferramenta";
            item.valorItem = "1000000";
            item.fornecedor = "TexugoBolado";
            item.observacao = "Top o Produto";

            //Coloca a tabela!!
            item.buscarFicharioSql(1,"dbo.item");




        }
    }
}
