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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Frm_CadastroFornecedor";

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastroCC));
            button1 = new Button();
            lbl_orcamento = new Label();
            txt_descricao = new TextBox();
            lbl_descricao = new Label();
            txt_codigo = new TextBox();
            lbl_codigo = new Label();
            pictureBox1 = new PictureBox();
            txt_orcamento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 603);
            button1.Name = "button1";
            button1.Size = new Size(390, 36);
            button1.TabIndex = 23;
            button1.Text = "Cadastrar Centro de Custo";
            button1.UseVisualStyleBackColor = true;
       
            // 
            // lbl_orcamento
            // 
            lbl_orcamento.AutoSize = true;
            lbl_orcamento.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_orcamento.ForeColor = SystemColors.ControlLightLight;
            lbl_orcamento.Location = new Point(12, 443);
            lbl_orcamento.Name = "lbl_orcamento";
            lbl_orcamento.Size = new Size(152, 34);
            lbl_orcamento.TabIndex = 21;
            lbl_orcamento.Text = "Orçamento";
            // 
            // txt_descricao
            // 
            txt_descricao.Location = new Point(12, 360);
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Size = new Size(390, 27);
            txt_descricao.TabIndex = 18;
            // 
            // lbl_descricao
            // 
            lbl_descricao.AutoSize = true;
            lbl_descricao.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_descricao.ForeColor = SystemColors.ControlLightLight;
            lbl_descricao.Location = new Point(12, 323);
            lbl_descricao.Name = "lbl_descricao";
            lbl_descricao.Size = new Size(134, 34);
            lbl_descricao.TabIndex = 17;
            lbl_descricao.Text = "Descrição";
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(12, 231);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(390, 27);
            txt_codigo.TabIndex = 16;
            // 
            // lbl_codigo
            // 
            lbl_codigo.AutoSize = true;
            lbl_codigo.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_codigo.ForeColor = SystemColors.ControlLightLight;
            lbl_codigo.Location = new Point(12, 194);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(98, 34);
            lbl_codigo.TabIndex = 15;
            lbl_codigo.Text = "Código";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(765, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // txt_orcamento
            // 
            txt_orcamento.Location = new Point(12, 480);
            txt_orcamento.Name = "txt_orcamento";
            txt_orcamento.Size = new Size(390, 27);
            txt_orcamento.TabIndex = 25;
            // 
            // frm_CadastroCC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(789, 651);
            Controls.Add(txt_orcamento);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lbl_orcamento);
            Controls.Add(txt_descricao);
            Controls.Add(lbl_descricao);
            Controls.Add(txt_codigo);
            Controls.Add(lbl_codigo);
            Name = "frm_CadastroCC";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Centro de Custo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label lbl_orcamento;
        private TextBox txt_descricao;
        private Label lbl_descricao;
        private TextBox txt_codigo;
        private Label lbl_codigo;
        private PictureBox pictureBox1;
        private TextBox txt_orcamento;
    }

}
