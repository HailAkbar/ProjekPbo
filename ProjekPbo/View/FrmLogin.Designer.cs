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
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblDaftar = new LinkLabel();
            lblLupaPassword = new LinkLabel();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(75, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(81, 219);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(134, 291);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblDaftar
            // 
            lblDaftar.AutoSize = true;
            lblDaftar.Location = new Point(145, 368);
            lblDaftar.Name = "lblDaftar";
            lblDaftar.Size = new Size(84, 20);
            lblDaftar.TabIndex = 3;
            lblDaftar.TabStop = true;
            lblDaftar.Text = "Daftar dulu";
            lblDaftar.LinkClicked += lblDaftar_LinkClicked;
            // 
            // lblLupaPassword
            // 
            lblLupaPassword.AutoSize = true;
            lblLupaPassword.Location = new Point(147, 405);
            lblLupaPassword.Name = "lblLupaPassword";
            lblLupaPassword.Size = new Size(113, 20);
            lblLupaPassword.TabIndex = 4;
            lblLupaPassword.TabStop = true;
            lblLupaPassword.Text = "Lupa Password?";
            lblLupaPassword.LinkClicked += lblLupaPassword_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 450);
            Controls.Add(lblLupaPassword);
            Controls.Add(lblDaftar);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "FrmLogin";
            Text = "Form1";
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
