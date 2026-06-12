namespace ProjekPbo
{
    partial class FrmLogin
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
            TextBox txtEmail;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblDaftar = new LinkLabel();
            lblLupaPassword = new LinkLabel();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(47, 255);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.ShortcutsEnabled = false;
            txtEmail.Size = new Size(293, 43);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(47, 319);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(293, 47);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(46, 420);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(299, 51);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblDaftar
            // 
            lblDaftar.AutoSize = true;
            lblDaftar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDaftar.Location = new Point(239, 492);
            lblDaftar.Name = "lblDaftar";
            lblDaftar.Size = new Size(73, 17);
            lblDaftar.TabIndex = 3;
            lblDaftar.TabStop = true;
            lblDaftar.Text = "Daftar dulu";
            lblDaftar.LinkClicked += lblDaftar_LinkClicked;
            // 
            // lblLupaPassword
            // 
            lblLupaPassword.AutoSize = true;
            lblLupaPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLupaPassword.Location = new Point(216, 385);
            lblLupaPassword.Name = "lblLupaPassword";
            lblLupaPassword.Size = new Size(121, 21);
            lblLupaPassword.TabIndex = 4;
            lblLupaPassword.TabStop = true;
            lblLupaPassword.Text = "Lupa Password?";
            lblLupaPassword.LinkClicked += lblLupaPassword_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(386, 749);
            Controls.Add(lblLupaPassword);
            Controls.Add(lblDaftar);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            Text = "Form1";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel lblDaftar;
        private LinkLabel lblLupaPassword;
    }
}
