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
            btnKeberanda = new Button();
            btnKeUpload = new Button();
            btnKeRiwayat = new Button();
            btnKeProfil = new Button();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.Location = new Point(149, 238);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(88, 34);
            lblNama.TabIndex = 0;
            lblNama.Text = "label1";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(101, 332);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 30);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "label3";
            // 
            // lblNoHP
            // 
            lblNoHP.Location = new Point(101, 406);
            lblNoHP.Name = "lblNoHP";
            lblNoHP.Size = new Size(103, 31);
            lblNoHP.TabIndex = 4;
            lblNoHP.Text = "label5";
            // 
            // lblAlamat
            // 
            lblAlamat.Location = new Point(101, 497);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(103, 35);
            lblAlamat.TabIndex = 5;
            lblAlamat.Text = "label6";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(41, 585);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(302, 67);
            btnLogout.TabIndex = 6;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(33, 924);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnKeberanda
            // 
            btnKeberanda.BackColor = Color.Transparent;
            btnKeberanda.FlatAppearance.BorderSize = 0;
            btnKeberanda.FlatStyle = FlatStyle.Flat;
            btnKeberanda.Location = new Point(41, 676);
            btnKeberanda.Name = "btnKeberanda";
            btnKeberanda.Size = new Size(60, 53);
            btnKeberanda.TabIndex = 8;
            btnKeberanda.UseVisualStyleBackColor = false;
            btnKeberanda.Click += btnKeberanda_Click;
            // 
            // btnKeUpload
            // 
            btnKeUpload.BackColor = Color.Transparent;
            btnKeUpload.FlatAppearance.BorderSize = 0;
            btnKeUpload.FlatStyle = FlatStyle.Flat;
            btnKeUpload.Location = new Point(130, 676);
            btnKeUpload.Name = "btnKeUpload";
            btnKeUpload.Size = new Size(52, 53);
            btnKeUpload.TabIndex = 9;
            btnKeUpload.UseVisualStyleBackColor = false;
            btnKeUpload.Click += btnKeUpload_Click;
            // 
            // btnKeRiwayat
            // 
            btnKeRiwayat.BackColor = Color.Transparent;
            btnKeRiwayat.FlatAppearance.BorderSize = 0;
            btnKeRiwayat.FlatStyle = FlatStyle.Flat;
            btnKeRiwayat.Location = new Point(207, 676);
            btnKeRiwayat.Name = "btnKeRiwayat";
            btnKeRiwayat.Size = new Size(71, 53);
            btnKeRiwayat.TabIndex = 10;
            btnKeRiwayat.UseVisualStyleBackColor = false;
            btnKeRiwayat.Click += btnKeRiwayat_Click;
            // 
            // btnKeProfil
            // 
            btnKeProfil.BackColor = Color.Transparent;
            btnKeProfil.FlatAppearance.BorderSize = 0;
            btnKeProfil.FlatStyle = FlatStyle.Flat;
            btnKeProfil.Location = new Point(284, 676);
            btnKeProfil.Name = "btnKeProfil";
            btnKeProfil.Size = new Size(71, 53);
            btnKeProfil.TabIndex = 11;
            btnKeProfil.UseVisualStyleBackColor = false;
            btnKeProfil.Click += btnKeProfil_Click;
            // 
            // FrmProfilDonatur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 741);
            Controls.Add(btnKeProfil);
            Controls.Add(btnKeRiwayat);
            Controls.Add(btnKeUpload);
            Controls.Add(btnKeberanda);
            Controls.Add(btnKembali);
            Controls.Add(btnLogout);
            Controls.Add(lblAlamat);
            Controls.Add(lblNoHP);
            Controls.Add(lblEmail);
            Controls.Add(lblNama);
            Name = "FrmProfilDonatur";
            Text = "FrmProfil";
            Load += FrmProfilDonatur_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblNama;
        private Label lblEmail;
        private Label lblNoHP;
        private Label lblAlamat;
        private Button btnLogout;
        private Button btnKembali;
        private Button btnKeberanda;
        private Button btnKeUpload;
        private Button btnKeRiwayat;
        private Button btnKeProfil;
    }
}