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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblDaftar = new LinkLabel();
            lblLupaPassword = new LinkLabel();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Inter SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(92, 324);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(239, 34);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(45, 415);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(299, 54);
            btnLogin.TabIndex = 2;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblDaftar
            // 
            lblDaftar.AutoSize = true;
            lblDaftar.BackColor = Color.Transparent;
            lblDaftar.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDaftar.LinkBehavior = LinkBehavior.NeverUnderline;
            lblDaftar.LinkColor = Color.FromArgb(142, 142, 142);
            lblDaftar.Location = new Point(235, 482);
            lblDaftar.Name = "lblDaftar";
            lblDaftar.Size = new Size(90, 22);
            lblDaftar.TabIndex = 3;
            lblDaftar.TabStop = true;
            lblDaftar.Text = "Daftar dulu";
            lblDaftar.LinkClicked += lblDaftar_LinkClicked;
            // 
            // lblLupaPassword
            // 
            lblLupaPassword.AutoSize = true;
            lblLupaPassword.BackColor = Color.Transparent;
            lblLupaPassword.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLupaPassword.LinkBehavior = LinkBehavior.NeverUnderline;
            lblLupaPassword.LinkColor = Color.FromArgb(142, 142, 142);
            lblLupaPassword.Location = new Point(213, 379);
            lblLupaPassword.Name = "lblLupaPassword";
            lblLupaPassword.Size = new Size(129, 22);
            lblLupaPassword.TabIndex = 4;
            lblLupaPassword.TabStop = true;
            lblLupaPassword.Text = "Lupa Password?";
            lblLupaPassword.LinkClicked += lblLupaPassword_LinkClicked;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Inter SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(92, 261);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(239, 31);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // FrmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(384, 741);
            Controls.Add(txtEmail);
            Controls.Add(lblLupaPassword);
            Controls.Add(lblDaftar);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REUSEHUB";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel lblDaftar;
        private LinkLabel lblLupaPassword;
        private TextBox txtEmail;
    }
}
