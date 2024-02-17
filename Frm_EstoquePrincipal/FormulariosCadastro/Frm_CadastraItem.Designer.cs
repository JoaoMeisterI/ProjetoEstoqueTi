namespace EstoqueTI
{
    partial class Frm_CadastraItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastraItem));
            button1 = new Button();
            cb_categoria = new ComboBox();
            lbl_categoria = new Label();
            txt_observacao = new TextBox();
            lbl_observacao = new Label();
            txt_item = new TextBox();
            lbl_item = new Label();
            pictureBox1 = new PictureBox();
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
            button1.Text = "Cadastrar Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // cb_categoria
            // 
            cb_categoria.FormattingEnabled = true;
            cb_categoria.Items.AddRange(new object[] { "Periféricos", "Computador", "Infraestrutura Som", "Infraestutura Rede", "Servidor", "Contrato Sistemas", "Customização" });
            cb_categoria.Location = new Point(12, 480);
            cb_categoria.Name = "cb_categoria";
            cb_categoria.Size = new Size(390, 28);
            cb_categoria.TabIndex = 22;
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_categoria.ForeColor = SystemColors.ControlLightLight;
            lbl_categoria.Location = new Point(12, 443);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(132, 34);
            lbl_categoria.TabIndex = 21;
            lbl_categoria.Text = "Categoria";
            // 
            // txt_observacao
            // 
            txt_observacao.Location = new Point(12, 360);
            txt_observacao.Name = "txt_observacao";
            txt_observacao.Size = new Size(390, 27);
            txt_observacao.TabIndex = 18;
            // 
            // lbl_observacao
            // 
            lbl_observacao.AutoSize = true;
            lbl_observacao.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_observacao.ForeColor = SystemColors.ControlLightLight;
            lbl_observacao.Location = new Point(12, 323);
            lbl_observacao.Name = "lbl_observacao";
            lbl_observacao.Size = new Size(160, 34);
            lbl_observacao.TabIndex = 17;
            lbl_observacao.Text = "Observação";
            // 
            // txt_item
            // 
            txt_item.Location = new Point(12, 231);
            txt_item.Name = "txt_item";
            txt_item.Size = new Size(390, 27);
            txt_item.TabIndex = 16;
            // 
            // lbl_item
            // 
            lbl_item.AutoSize = true;
            lbl_item.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_item.ForeColor = SystemColors.ControlLightLight;
            lbl_item.Location = new Point(12, 194);
            lbl_item.Name = "lbl_item";
            lbl_item.Size = new Size(73, 34);
            lbl_item.TabIndex = 15;
            lbl_item.Text = "Item";
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
            // Frm_CadastraItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(789, 651);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(cb_categoria);
            Controls.Add(lbl_categoria);
            Controls.Add(txt_observacao);
            Controls.Add(lbl_observacao);
            Controls.Add(txt_item);
            Controls.Add(lbl_item);
            Name = "Frm_CadastraItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Item";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ComboBox cb_categoria;
        private Label lbl_categoria;
        private TextBox txt_observacao;
        private Label lbl_observacao;
        private TextBox txt_item;
        private Label lbl_item;
        private PictureBox pictureBox1;
    }
}