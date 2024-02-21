using Frm_EstoquePrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EstoqueTI.Classes.User;

namespace EstoqueTI.FormulariosIniciais
{
    public partial class Frm_TelaDeLogin : Form
    {
        
        public Frm_TelaDeLogin()
        {
            InitializeComponent();


        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                Unit u = new Unit();
                u.BuscarUserSQLREL(txt_login.Text, txt_senha.Text);
                Frm_Estoque frm = new Frm_Estoque();
                this.Hide();
                frm.Show();
                








            }
            catch (Exception ex) 
            {
                MessageBox.Show("Usuário não cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        
    }
}
