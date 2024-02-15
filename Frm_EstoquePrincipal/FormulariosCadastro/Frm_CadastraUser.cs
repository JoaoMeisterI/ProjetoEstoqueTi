﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EstoqueTI.Classes.User;
using EstoqueTI.FuncoesUteis;

namespace EstoqueTI
{
    
    public partial class Frm_CadastraUser : Form

    {

        int ID;
        public Frm_CadastraUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                FuncoesUteis.Funcoes buscaId = new Funcoes();
                int ID = buscaId.BuscarFicharioId("dbo.usuarios");

                Unit u = new Unit();
                u.id = ID += 1;
                u.nome = txt_nome.Text;
                u.usuario = txt_usuario.Text;
                u.senha = txt_senha.Text;
                u.liberacao = cb_liberacao.Text;
                u.ValidaClasse();
                u.IncluirFicharioSQLREL();

               

                
               

                MessageBox.Show($"Usuário {txt_usuario.Text} cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ValidationException Ex )
            {
                MessageBox.Show(Ex.Message, "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
