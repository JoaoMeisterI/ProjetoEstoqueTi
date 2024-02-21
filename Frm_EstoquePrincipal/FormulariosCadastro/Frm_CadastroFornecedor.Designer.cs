namespace EstoqueTI.FormulariosCadastro
{
    partial class Frm_CadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroFornecedor));
            btn_fornecedor = new Button();
            lbl_contato = new Label();
            txt_nome = new TextBox();
            lbl_nome = new Label();
            txt_cnpj = new TextBox();
            lbl_cnpj = new Label();
            txt_contato = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_fornecedor
            // 
            btn_fornecedor.ForeColor = Color.Black;
            btn_fornecedor.Location = new Point(12, 603);
            btn_fornecedor.Name = "btn_fornecedor";
            btn_fornecedor.Size = new Size(390, 36);
            btn_fornecedor.TabIndex = 23;
            btn_fornecedor.Text = "Cadastrar Fornecedor";
            btn_fornecedor.UseVisualStyleBackColor = true;
            btn_fornecedor.Click += button1_Click;
            // 
            // lbl_contato
            // 
            lbl_contato.AutoSize = true;
            lbl_contato.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_contato.ForeColor = SystemColors.ControlLightLight;
            lbl_contato.Location = new Point(12, 443);
            lbl_contato.Name = "lbl_contato";
            lbl_contato.Size = new Size(111, 34);
            lbl_contato.TabIndex = 21;
            lbl_contato.Text = "Contato";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(12, 360);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(390, 27);
            txt_nome.TabIndex = 18;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nome.ForeColor = SystemColors.ControlLightLight;
            lbl_nome.Location = new Point(12, 323);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(88, 34);
            lbl_nome.TabIndex = 17;
            lbl_nome.Text = "Nome";
            // 
            // txt_cnpj
            // 
            txt_cnpj.Location = new Point(12, 231);
            txt_cnpj.Name = "txt_cnpj";
            txt_cnpj.Size = new Size(390, 27);
            txt_cnpj.TabIndex = 16;
            // 
            // lbl_cnpj
            // 
            lbl_cnpj.AutoSize = true;
            lbl_cnpj.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cnpj.ForeColor = SystemColors.ControlLightLight;
            lbl_cnpj.Location = new Point(12, 194);
            lbl_cnpj.Name = "lbl_cnpj";
            lbl_cnpj.Size = new Size(71, 34);
            lbl_cnpj.TabIndex = 15;
            lbl_cnpj.Text = "Cnpj";
            // 
            // txt_contato
            // 
            txt_contato.Location = new Point(12, 480);
            txt_contato.Name = "txt_contato";
            txt_contato.Size = new Size(390, 27);
            txt_contato.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(765, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // Frm_CadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(789, 651);
            Controls.Add(pictureBox1);
            Controls.Add(txt_contato);
            Controls.Add(btn_fornecedor);
            Controls.Add(lbl_contato);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            Controls.Add(txt_cnpj);
            Controls.Add(lbl_cnpj);
            Name = "Frm_CadastroFornecedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Fornecedor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_fornecedor;
        private Label lbl_contato;
        private TextBox txt_nome;
        private Label lbl_nome;
        private TextBox txt_cnpj;
        private Label lbl_cnpj;
        private TextBox txt_contato;
        private PictureBox pictureBox1;
    }

}
