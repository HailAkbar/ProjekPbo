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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfilDonatur));
            lblNama = new Label();
            lblEmail = new Label();
            lblNoHP = new Label();
            lblAlamat = new Label();
            btnLogout = new Button();
            btnKembali = new Button();
            lblNamaAtas = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(173, 247);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(38, 15);
            lblNama.TabIndex = 0;
            lblNama.Text = "label1";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(120, 342);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(38, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "label3";
            // 
            // lblNoHP
            // 
            lblNoHP.AutoSize = true;
            lblNoHP.Location = new Point(120, 417);
            lblNoHP.Name = "lblNoHP";
            lblNoHP.Size = new Size(38, 15);
            lblNoHP.TabIndex = 4;
            lblNoHP.Text = "label5";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(120, 513);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(38, 15);
            lblAlamat.TabIndex = 5;
            lblAlamat.Text = "label6";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(43, 595);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(296, 60);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(29, 693);
            btnKembali.Margin = new Padding(3, 2, 3, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(82, 22);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // lblNamaAtas
            // 
            lblNamaAtas.AutoSize = true;
            lblNamaAtas.Location = new Point(206, 87);
            lblNamaAtas.Name = "lblNamaAtas";
            lblNamaAtas.Size = new Size(38, 15);
            lblNamaAtas.TabIndex = 3;
            lblNamaAtas.Text = "label4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 87);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "HALO,";
            // 
            // FrmProfilDonatur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(386, 749);
            Controls.Add(btnKembali);
            Controls.Add(btnLogout);
            Controls.Add(lblAlamat);
            Controls.Add(lblNoHP);
            Controls.Add(lblNamaAtas);
            Controls.Add(lblEmail);
            Controls.Add(label2);
            Controls.Add(lblNama);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmProfilDonatur";
            Text = "FrmProfil";
            Load += FrmProfilDonatur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private Label lblEmail;
        private Label lblNoHP;
        private Label lblAlamat;
        private Button btnLogout;
        private Button btnKembali;
        private Label lblNamaAtas;
        private Label label2;
    }
}