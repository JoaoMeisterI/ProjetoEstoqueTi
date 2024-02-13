﻿namespace EstoqueTI
{
    partial class Frm_CadastraUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastraUser));
            pictureBox1 = new PictureBox();
            lbl_nome = new Label();
            txt_nome = new TextBox();
            lbl_usuario = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            lbl_liberacao = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(765, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nome.ForeColor = SystemColors.ControlLightLight;
            lbl_nome.Location = new Point(12, 178);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(88, 34);
            lbl_nome.TabIndex = 6;
            lbl_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(12, 215);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(390, 27);
            txt_nome.TabIndex = 7;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = SystemColors.ControlLightLight;
            lbl_usuario.Location = new Point(12, 266);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(108, 34);
            lbl_usuario.TabIndex = 8;
            lbl_usuario.Text = "Usuário";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(12, 303);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(390, 27);
            txt_usuario.TabIndex = 9;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(12, 398);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(390, 27);
            txt_senha.TabIndex = 11;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_senha.ForeColor = SystemColors.ControlLightLight;
            lbl_senha.Location = new Point(12, 361);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(93, 34);
            lbl_senha.TabIndex = 10;
            lbl_senha.Text = "Senha";
            // 
            // lbl_liberacao
            // 
            lbl_liberacao.AutoSize = true;
            lbl_liberacao.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_liberacao.ForeColor = SystemColors.ControlLightLight;
            lbl_liberacao.Location = new Point(12, 459);
            lbl_liberacao.Name = "lbl_liberacao";
            lbl_liberacao.Size = new Size(133, 34);
            lbl_liberacao.TabIndex = 12;
            lbl_liberacao.Text = "Liberação";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Usuário Padrão" });
            comboBox1.Location = new Point(12, 496);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(390, 28);
            comboBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 599);
            button1.Name = "button1";
            button1.Size = new Size(390, 36);
            button1.TabIndex = 14;
            button1.Text = "Criar Usuário";
            button1.UseVisualStyleBackColor = true;
            // 
            // Frm_CadastraUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(789, 651);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(lbl_liberacao);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_usuario);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            Controls.Add(pictureBox1);
            ForeColor = Color.Tan;
            Name = "Frm_CadastraUser";
            Text = "Cadastra Usuário";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_nome;
        private TextBox txt_nome;
        private Label lbl_usuario;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Label lbl_senha;
        private Label lbl_liberacao;
        private ComboBox comboBox1;
        private Button button1;
    }
}