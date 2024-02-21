namespace EstoqueTI
{
    partial class Frm_Recebe
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Recebe));
            lbl_item = new Label();
            lbl_valor = new Label();
            txt_valor = new TextBox();
            lbl_fornecedor = new Label();
            lbl_motivo = new Label();
            btn_recebe = new Button();
            pictureBox1 = new PictureBox();
            cb_fornecedor = new ComboBox();
            cb_item = new ComboBox();
            rb_motivo = new RichTextBox();
            lbl_data = new Label();
            dt_date = new DateTimePicker();
            lbl_quantidade = new Label();
            nd_quantidade = new NumericUpDown();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nd_quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lbl_item
            // 
            lbl_item.AutoSize = true;
            lbl_item.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_item.ForeColor = SystemColors.ControlLightLight;
            lbl_item.Location = new Point(12, 178);
            lbl_item.Name = "lbl_item";
            lbl_item.Size = new Size(73, 34);
            lbl_item.TabIndex = 6;
            lbl_item.Text = "Item";
            // 
            // lbl_valor
            // 
            lbl_valor.AutoSize = true;
            lbl_valor.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_valor.ForeColor = SystemColors.ControlLightLight;
            lbl_valor.Location = new Point(12, 266);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(78, 34);
            lbl_valor.TabIndex = 8;
            lbl_valor.Text = "Valor";
            // 
            // txt_valor
            // 
            txt_valor.Location = new Point(12, 303);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(390, 27);
            txt_valor.TabIndex = 9;
            // 
            // lbl_fornecedor
            // 
            lbl_fornecedor.AutoSize = true;
            lbl_fornecedor.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fornecedor.ForeColor = SystemColors.ControlLightLight;
            lbl_fornecedor.Location = new Point(12, 361);
            lbl_fornecedor.Name = "lbl_fornecedor";
            lbl_fornecedor.Size = new Size(154, 34);
            lbl_fornecedor.TabIndex = 10;
            lbl_fornecedor.Text = "Fornecedor";
            // 
            // lbl_motivo
            // 
            lbl_motivo.AutoSize = true;
            lbl_motivo.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_motivo.ForeColor = SystemColors.ControlLightLight;
            lbl_motivo.Location = new Point(12, 442);
            lbl_motivo.Name = "lbl_motivo";
            lbl_motivo.Size = new Size(96, 34);
            lbl_motivo.TabIndex = 12;
            lbl_motivo.Text = "Motivo";
            // 
            // btn_recebe
            // 
            btn_recebe.ForeColor = Color.Black;
            btn_recebe.Location = new Point(12, 685);
            btn_recebe.Name = "btn_recebe";
            btn_recebe.Size = new Size(850, 46);
            btn_recebe.TabIndex = 14;
            btn_recebe.Text = "Receber Item";
            btn_recebe.UseVisualStyleBackColor = true;
            btn_recebe.Click += btn_usuario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(869, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // cb_fornecedor
            // 
            cb_fornecedor.FormattingEnabled = true;
            cb_fornecedor.Items.AddRange(new object[] { "Administrador", "Usuário Padrão" });
            cb_fornecedor.Location = new Point(12, 398);
            cb_fornecedor.Name = "cb_fornecedor";
            cb_fornecedor.Size = new Size(390, 28);
            cb_fornecedor.TabIndex = 16;
            // 
            // cb_item
            // 
            cb_item.FormattingEnabled = true;
            cb_item.Items.AddRange(new object[] { "Administrador", "Usuário Padrão" });
            cb_item.Location = new Point(12, 225);
            cb_item.Name = "cb_item";
            cb_item.Size = new Size(390, 28);
            cb_item.TabIndex = 17;
            // 
            // rb_motivo
            // 
            rb_motivo.Location = new Point(12, 479);
            rb_motivo.Name = "rb_motivo";
            rb_motivo.Size = new Size(390, 132);
            rb_motivo.TabIndex = 18;
            rb_motivo.Text = "";
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_data.ForeColor = SystemColors.ControlLightLight;
            lbl_data.Location = new Point(431, 178);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(73, 34);
            lbl_data.TabIndex = 19;
            lbl_data.Text = "Data";
            // 
            // dt_date
            // 
            dt_date.Location = new Point(431, 223);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(431, 27);
            dt_date.TabIndex = 20;
            // 
            // lbl_quantidade
            // 
            lbl_quantidade.AutoSize = true;
            lbl_quantidade.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_quantidade.ForeColor = SystemColors.ControlLightLight;
            lbl_quantidade.Location = new Point(431, 266);
            lbl_quantidade.Name = "lbl_quantidade";
            lbl_quantidade.Size = new Size(157, 34);
            lbl_quantidade.TabIndex = 21;
            lbl_quantidade.Text = "Quantidade";
            // 
            // nd_quantidade
            // 
            nd_quantidade.Location = new Point(431, 304);
            nd_quantidade.Name = "nd_quantidade";
            nd_quantidade.Size = new Size(431, 27);
            nd_quantidade.TabIndex = 22;
            // 
            // Frm_Recebe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(874, 743);
            Controls.Add(nd_quantidade);
            Controls.Add(lbl_quantidade);
            Controls.Add(dt_date);
            Controls.Add(lbl_data);
            Controls.Add(rb_motivo);
            Controls.Add(cb_item);
            Controls.Add(cb_fornecedor);
            Controls.Add(pictureBox1);
            Controls.Add(btn_recebe);
            Controls.Add(lbl_motivo);
            Controls.Add(lbl_fornecedor);
            Controls.Add(txt_valor);
            Controls.Add(lbl_valor);
            Controls.Add(lbl_item);
            ForeColor = Color.Tan;
            Name = "Frm_Recebe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recebe Item";
            Load += Frm_Recebe_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nd_quantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_item;
        private Label lbl_valor;
        private TextBox txt_valor;
        private Label lbl_fornecedor;
        private Label lbl_motivo;
        private Button btn_recebe;
        private PictureBox pictureBox1;
        private ComboBox cb_fornecedor;
        private ComboBox cb_item;
        private RichTextBox rb_motivo;
        private Label lbl_data;
        private DateTimePicker dt_date;
        private Label lbl_quantidade;
        private NumericUpDown nd_quantidade;
        private BindingSource bindingSource1;
    }

}