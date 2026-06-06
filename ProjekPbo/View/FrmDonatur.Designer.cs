namespace ProjekPbo.View
{
    partial class FrmDonatur
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
            lblMenunggu = new Label();
            lblDiterima = new Label();
            lblDitolak = new Label();
            lblSelesai = new Label();
            flpBarang = new FlowLayoutPanel();
            btnUpload = new Button();
            btnRiwayat = new Button();
            btnProfil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 79);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Halo,";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(173, 79);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(49, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama";
            lblNama.TextChanged += FrmDonatur_Load;
            // 
            // lblMenunggu
            // 
            lblMenunggu.AutoSize = true;
            lblMenunggu.Location = new Point(47, 144);
            lblMenunggu.Name = "lblMenunggu";
            lblMenunggu.Size = new Size(50, 20);
            lblMenunggu.TabIndex = 2;
            lblMenunggu.Text = "label3";
            // 
            // lblDiterima
            // 
            lblDiterima.AutoSize = true;
            lblDiterima.Location = new Point(49, 171);
            lblDiterima.Name = "lblDiterima";
            lblDiterima.Size = new Size(50, 20);
            lblDiterima.TabIndex = 3;
            lblDiterima.Text = "label4";
            // 
            // lblDitolak
            // 
            lblDitolak.AutoSize = true;
            lblDitolak.Location = new Point(51, 210);
            lblDitolak.Name = "lblDitolak";
            lblDitolak.Size = new Size(50, 20);
            lblDitolak.TabIndex = 4;
            lblDitolak.Text = "label5";
            // 
            // lblSelesai
            // 
            lblSelesai.AutoSize = true;
            lblSelesai.Location = new Point(47, 239);
            lblSelesai.Name = "lblSelesai";
            lblSelesai.Size = new Size(50, 20);
            lblSelesai.TabIndex = 5;
            lblSelesai.Text = "label6";
            // 
            // flpBarang
            // 
            flpBarang.Location = new Point(80, 273);
            flpBarang.Name = "flpBarang";
            flpBarang.Size = new Size(250, 93);
            flpBarang.TabIndex = 7;
            flpBarang.Click += FrmDonatur_Load;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(25, 405);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(94, 29);
            btnUpload.TabIndex = 8;
            btnUpload.Text = "Upload Barang";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Location = new Point(147, 405);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(94, 29);
            btnRiwayat.TabIndex = 9;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnProfil
            // 
            btnProfil.Location = new Point(275, 405);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(94, 29);
            btnProfil.TabIndex = 10;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = true;
            // 
            // FrmDonatur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(btnProfil);
            Controls.Add(btnRiwayat);
            Controls.Add(btnUpload);
            Controls.Add(flpBarang);
            Controls.Add(lblSelesai);
            Controls.Add(lblDitolak);
            Controls.Add(lblDiterima);
            Controls.Add(lblMenunggu);
            Controls.Add(lblNama);
            Controls.Add(label1);
            Name = "FrmDonatur";
            Text = "FrmDonatur";
            Load += FrmDonatur_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNama;
        private Label lblMenunggu;
        private Label lblDiterima;
        private Label lblDitolak;
        private Label lblSelesai;
        private FlowLayoutPanel flpBarang;
        private Button btnUpload;
        private Button btnRiwayat;
        private Button btnProfil;
    }
}