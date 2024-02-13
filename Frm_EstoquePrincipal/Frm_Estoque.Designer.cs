namespace Frm_EstoquePrincipal
{
    partial class Frm_Estoque
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estoque));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            movimentoDeEstoqueToolStripMenuItem = new ToolStripMenuItem();
            transferirMaterialToolStripMenuItem = new ToolStripMenuItem();
            receberMaterialToolStripMenuItem = new ToolStripMenuItem();
            consultaDeEstoqueToolStripMenuItem = new ToolStripMenuItem();
            materiasDisponíveisToolStripMenuItem = new ToolStripMenuItem();
            historicoDeMovimToolStripMenuItem = new ToolStripMenuItem();
            historicoDeComprasToolStripMenuItem = new ToolStripMenuItem();
            custoMaterialToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 978);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.Location = new Point(21, 587);
            button4.MaximumSize = new Size(204, 50);
            button4.Name = "button4";
            button4.Size = new Size(204, 50);
            button4.TabIndex = 3;
            button4.Text = "Cadastro de Material";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.Location = new Point(21, 663);
            button3.MaximumSize = new Size(204, 50);
            button3.Name = "button3";
            button3.Size = new Size(204, 50);
            button3.TabIndex = 2;
            button3.Text = "Cadastro de Fornecedor";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Location = new Point(21, 815);
            button2.MaximumSize = new Size(204, 50);
            button2.Name = "button2";
            button2.Size = new Size(204, 50);
            button2.TabIndex = 1;
            button2.Text = "Cadastro de Usuário";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(21, 739);
            button1.MaximumSize = new Size(204, 50);
            button1.Name = "button1";
            button1.Size = new Size(204, 50);
            button1.TabIndex = 0;
            button1.Text = "Cadastro de Centro de Custo";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(252, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 35);
            panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { movimentoDeEstoqueToolStripMenuItem, consultaDeEstoqueToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // movimentoDeEstoqueToolStripMenuItem
            // 
            movimentoDeEstoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { transferirMaterialToolStripMenuItem, receberMaterialToolStripMenuItem });
            movimentoDeEstoqueToolStripMenuItem.Name = "movimentoDeEstoqueToolStripMenuItem";
            movimentoDeEstoqueToolStripMenuItem.Size = new Size(181, 31);
            movimentoDeEstoqueToolStripMenuItem.Text = "Movimento de estoque ";
            // 
            // transferirMaterialToolStripMenuItem
            // 
            transferirMaterialToolStripMenuItem.Name = "transferirMaterialToolStripMenuItem";
            transferirMaterialToolStripMenuItem.Size = new Size(224, 26);
            transferirMaterialToolStripMenuItem.Text = "Transferir Material";
            // 
            // receberMaterialToolStripMenuItem
            // 
            receberMaterialToolStripMenuItem.Name = "receberMaterialToolStripMenuItem";
            receberMaterialToolStripMenuItem.Size = new Size(224, 26);
            receberMaterialToolStripMenuItem.Text = "Receber Material";
            // 
            // consultaDeEstoqueToolStripMenuItem
            // 
            consultaDeEstoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { materiasDisponíveisToolStripMenuItem, historicoDeMovimToolStripMenuItem, historicoDeComprasToolStripMenuItem, custoMaterialToolStripMenuItem });
            consultaDeEstoqueToolStripMenuItem.Name = "consultaDeEstoqueToolStripMenuItem";
            consultaDeEstoqueToolStripMenuItem.Size = new Size(158, 31);
            consultaDeEstoqueToolStripMenuItem.Text = "Consulta de estoque";
            // 
            // materiasDisponíveisToolStripMenuItem
            // 
            materiasDisponíveisToolStripMenuItem.Name = "materiasDisponíveisToolStripMenuItem";
            materiasDisponíveisToolStripMenuItem.Size = new Size(259, 26);
            materiasDisponíveisToolStripMenuItem.Text = "Materias disponíveis";
            // 
            // historicoDeMovimToolStripMenuItem
            // 
            historicoDeMovimToolStripMenuItem.Name = "historicoDeMovimToolStripMenuItem";
            historicoDeMovimToolStripMenuItem.Size = new Size(259, 26);
            historicoDeMovimToolStripMenuItem.Text = "Historico de movimentos";
            // 
            // historicoDeComprasToolStripMenuItem
            // 
            historicoDeComprasToolStripMenuItem.Name = "historicoDeComprasToolStripMenuItem";
            historicoDeComprasToolStripMenuItem.Size = new Size(259, 26);
            historicoDeComprasToolStripMenuItem.Text = "Historico de compras";
            // 
            // custoMaterialToolStripMenuItem
            // 
            custoMaterialToolStripMenuItem.Name = "custoMaterialToolStripMenuItem";
            custoMaterialToolStripMenuItem.Size = new Size(259, 26);
            custoMaterialToolStripMenuItem.Text = "Custo Material";
            // 
            // Frm_Estoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1243, 891);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Frm_Estoque";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ToolStripMenuItem movimentoDeEstoqueToolStripMenuItem;
        private ToolStripMenuItem transferirMaterialToolStripMenuItem;
        private ToolStripMenuItem receberMaterialToolStripMenuItem;
        private ToolStripMenuItem consultaDeEstoqueToolStripMenuItem;
        private ToolStripMenuItem materiasDisponíveisToolStripMenuItem;
        private ToolStripMenuItem historicoDeMovimToolStripMenuItem;
        private ToolStripMenuItem historicoDeComprasToolStripMenuItem;
        private ToolStripMenuItem custoMaterialToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
