namespace EstoqueTI.FormulariosConsulta
{
    partial class Frm_ConsultaItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultaItems));
            pictureBox1 = new PictureBox();
            dv_itens = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dv_itens).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1211, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // dv_itens
            // 
            dv_itens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dv_itens.Location = new Point(12, 217);
            dv_itens.Name = "dv_itens";
            dv_itens.RowHeadersWidth = 51;
            dv_itens.Size = new Size(1211, 602);
            dv_itens.TabIndex = 26;
            // 
            // Frm_ConsultaItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1235, 847);
            Controls.Add(dv_itens);
            Controls.Add(pictureBox1);
            Name = "Frm_ConsultaItems";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Itens";
            Load += Frm_ConsultaItems_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dv_itens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dv_itens;
    }
}