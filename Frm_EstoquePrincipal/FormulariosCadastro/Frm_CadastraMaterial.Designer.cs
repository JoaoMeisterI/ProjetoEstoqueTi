namespace EstoqueTI
{
    partial class Frm_CadastraMaterial
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
            label1 = new Label();
            txt_item = new TextBox();
            txt_valor = new TextBox();
            label2 = new Label();
            txt_fornecedor = new TextBox();
            label3 = new Label();
            txt_obs = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Item";
            // 
            // txt_item
            // 
            txt_item.Location = new Point(18, 47);
            txt_item.Name = "txt_item";
            txt_item.Size = new Size(140, 27);
            txt_item.TabIndex = 1;
            // 
            // txt_valor
            // 
            txt_valor.Location = new Point(18, 123);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(140, 27);
            txt_valor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 100);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor";
            // 
            // txt_fornecedor
            // 
            txt_fornecedor.Location = new Point(18, 199);
            txt_fornecedor.Name = "txt_fornecedor";
            txt_fornecedor.Size = new Size(140, 27);
            txt_fornecedor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 176);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 4;
            label3.Text = "Fornecedor ";
            // 
            // txt_obs
            // 
            txt_obs.Location = new Point(18, 278);
            txt_obs.Name = "txt_obs";
            txt_obs.Size = new Size(140, 27);
            txt_obs.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 255);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Observação";
            // 
            // button1
            // 
            button1.Location = new Point(18, 350);
            button1.Name = "button1";
            button1.Size = new Size(140, 34);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Frm_CadastraMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txt_obs);
            Controls.Add(label4);
            Controls.Add(txt_fornecedor);
            Controls.Add(label3);
            Controls.Add(txt_valor);
            Controls.Add(label2);
            Controls.Add(txt_item);
            Controls.Add(label1);
            Name = "Frm_CadastraMaterial";
            Text = "Frm_CadastraMaterial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_item;
        private TextBox txt_valor;
        private Label label2;
        private TextBox txt_fornecedor;
        private Label label3;
        private TextBox txt_obs;
        private Label label4;
        private Button button1;
    }
}