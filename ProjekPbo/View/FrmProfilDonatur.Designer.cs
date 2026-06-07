namespace ProjekPbo.View
{
    partial class FrmProfilDonatur
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
            lblNama = new Label();
            label2 = new Label();
            lblEmail = new Label();
            lblNamaAtas = new Label();
            lblNoHP = new Label();
            lblAlamat = new Label();
            btnLogout = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(45, 148);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(50, 20);
            lblNama.TabIndex = 0;
            lblNama.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 73);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "HALO,";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(45, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "label3";
            // 
            // lblNamaAtas
            // 
            lblNamaAtas.AutoSize = true;
            lblNamaAtas.Location = new Point(148, 73);
            lblNamaAtas.Name = "lblNamaAtas";
            lblNamaAtas.Size = new Size(50, 20);
            lblNamaAtas.TabIndex = 3;
            lblNamaAtas.Text = "label4";
            // 
            // lblNoHP
            // 
            lblNoHP.AutoSize = true;
            lblNoHP.Location = new Point(45, 218);
            lblNoHP.Name = "lblNoHP";
            lblNoHP.Size = new Size(50, 20);
            lblNoHP.TabIndex = 4;
            lblNoHP.Text = "label5";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(45, 256);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(50, 20);
            lblAlamat.TabIndex = 5;
            lblAlamat.Text = "label6";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(136, 286);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(45, 389);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // FrmProfilDonatur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 450);
            Controls.Add(btnKembali);
            Controls.Add(btnLogout);
            Controls.Add(lblAlamat);
            Controls.Add(lblNoHP);
            Controls.Add(lblNamaAtas);
            Controls.Add(lblEmail);
            Controls.Add(label2);
            Controls.Add(lblNama);
            Name = "FrmProfilDonatur";
            Text = "FrmProfil";
            Load += FrmProfilDonatur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private Label label2;
        private Label lblEmail;
        private Label lblNamaAtas;
        private Label lblNoHP;
        private Label lblAlamat;
        private Button btnLogout;
        private Button btnKembali;
    }
}