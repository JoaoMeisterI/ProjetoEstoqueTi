namespace EstoqueTI.FormulariosIniciais
{
    partial class Frm_TelaDeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TelaDeLogin));
            pictureBox1 = new PictureBox();
            txt_login = new TextBox();
            lbl_login = new Label();
            lbl_senha = new Label();
            txt_senha = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(675, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txt_login
            // 
            txt_login.Location = new Point(161, 227);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(371, 27);
            txt_login.TabIndex = 6;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = SystemColors.ControlLightLight;
            lbl_login.Location = new Point(161, 197);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(61, 27);
            lbl_login.TabIndex = 7;
            lbl_login.Text = "Login";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_senha.ForeColor = SystemColors.ControlLightLight;
            lbl_senha.Location = new Point(161, 268);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(65, 27);
            lbl_senha.TabIndex = 9;
            lbl_senha.Text = "Senha";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(161, 298);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(371, 27);
            txt_senha.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(161, 369);
            button1.Name = "button1";
            button1.Size = new Size(371, 35);
            button1.TabIndex = 10;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Frm_TelaDeLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(699, 469);
            Controls.Add(button1);
            Controls.Add(lbl_senha);
            Controls.Add(txt_senha);
            Controls.Add(lbl_login);
            Controls.Add(txt_login);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Frm_TelaDeLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_login;
        private Label lbl_login;
        private Label lbl_senha;
        private TextBox txt_senha;
        private Button button1;
    }
}