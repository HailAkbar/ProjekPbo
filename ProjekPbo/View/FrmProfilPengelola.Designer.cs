namespace ProjekPbo.View
{
    partial class FrmProfilPengelola
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
            lblNama = new Label();
            lblNamaAtas = new Label();
            lblEmail = new Label();
            lblNoHp = new Label();
            btnLogout = new Button();
            btnUbahPassword = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 73);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Halo Donatur,";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(51, 139);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(50, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "label2";
            // 
            // lblNamaAtas
            // 
            lblNamaAtas.AutoSize = true;
            lblNamaAtas.Location = new Point(186, 73);
            lblNamaAtas.Name = "lblNamaAtas";
            lblNamaAtas.Size = new Size(50, 20);
            lblNamaAtas.TabIndex = 2;
            lblNamaAtas.Text = "label3";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(51, 173);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "label4";
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Location = new Point(51, 210);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(50, 20);
            lblNoHp.TabIndex = 4;
            lblNoHp.Text = "label5";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(51, 286);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUbahPassword
            // 
            btnUbahPassword.Location = new Point(226, 286);
            btnUbahPassword.Name = "btnUbahPassword";
            btnUbahPassword.Size = new Size(94, 29);
            btnUbahPassword.TabIndex = 6;
            btnUbahPassword.Text = "Ganti PW";
            btnUbahPassword.UseVisualStyleBackColor = true;
            btnUbahPassword.Click += btnUbahPassword_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(130, 361);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // FrmProfilPengelola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(btnKembali);
            Controls.Add(btnUbahPassword);
            Controls.Add(btnLogout);
            Controls.Add(lblNoHp);
            Controls.Add(lblEmail);
            Controls.Add(lblNamaAtas);
            Controls.Add(lblNama);
            Controls.Add(label1);
            Name = "FrmProfilPengelola";
            Text = "FrmProfilPengelola";
            Load += FrmProfilPengelola_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNama;
        private Label lblNamaAtas;
        private Label lblEmail;
        private Label lblNoHp;
        private Button btnLogout;
        private Button btnUbahPassword;
        private Button btnKembali;
    }
}