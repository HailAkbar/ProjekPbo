namespace ProjekPbo.View
{
    partial class FrmPengelola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPengelola));
            lblNama = new Label();
            lblDiterima = new Label();
            lblDitolak = new Label();
            btnverifikasi = new Button();
            btnStatistik = new Button();
            btnKelola = new Button();
            btnProfil = new Button();
            lblMenunggu = new Label();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 10F);
            lblNama.Location = new Point(35, 128);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(60, 23);
            lblNama.TabIndex = 1;
            lblNama.Text = "NAMA";
            // 
            // lblDiterima
            // 
            lblDiterima.AutoSize = true;
            lblDiterima.Location = new Point(150, 294);
            lblDiterima.Name = "lblDiterima";
            lblDiterima.Size = new Size(17, 20);
            lblDiterima.TabIndex = 1;
            lblDiterima.Text = "0";
            // 
            // lblDitolak
            // 
            lblDitolak.AutoSize = true;
            lblDitolak.Location = new Point(150, 361);
            lblDitolak.Name = "lblDitolak";
            lblDitolak.Size = new Size(17, 20);
            lblDitolak.TabIndex = 2;
            lblDitolak.Text = "0";
            // 
            // btnverifikasi
            // 
            btnverifikasi.BackColor = Color.Transparent;
            btnverifikasi.FlatAppearance.BorderSize = 0;
            btnverifikasi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnverifikasi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnverifikasi.FlatStyle = FlatStyle.Flat;
            btnverifikasi.Font = new Font("Segoe UI", 7F);
            btnverifikasi.ForeColor = Color.Transparent;
            btnverifikasi.Location = new Point(30, 674);
            btnverifikasi.Name = "btnverifikasi";
            btnverifikasi.Size = new Size(65, 55);
            btnverifikasi.TabIndex = 5;
            btnverifikasi.TabStop = false;
            btnverifikasi.UseVisualStyleBackColor = false;
            btnverifikasi.Click += btnVerifikasi_Click;
            // 
            // btnStatistik
            // 
            btnStatistik.BackColor = Color.Transparent;
            btnStatistik.FlatAppearance.BorderSize = 0;
            btnStatistik.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStatistik.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStatistik.FlatStyle = FlatStyle.Flat;
            btnStatistik.Font = new Font("Segoe UI", 7F);
            btnStatistik.ForeColor = Color.Transparent;
            btnStatistik.Location = new Point(195, 673);
            btnStatistik.Name = "btnStatistik";
            btnStatistik.Size = new Size(75, 56);
            btnStatistik.TabIndex = 9;
            btnStatistik.TabStop = false;
            btnStatistik.UseVisualStyleBackColor = true;
            btnStatistik.Click += btnStatistik_Click;
            // 
            // btnKelola
            // 
            btnKelola.BackColor = Color.Transparent;
            btnKelola.FlatAppearance.BorderSize = 0;
            btnKelola.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKelola.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKelola.FlatStyle = FlatStyle.Flat;
            btnKelola.Font = new Font("Segoe UI", 7F);
            btnKelola.ForeColor = Color.Transparent;
            btnKelola.Location = new Point(101, 674);
            btnKelola.Name = "btnKelola";
            btnKelola.Size = new Size(88, 55);
            btnKelola.TabIndex = 10;
            btnKelola.TabStop = false;
            btnKelola.UseVisualStyleBackColor = true;
            btnKelola.Click += btnkelola_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Transparent;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProfil.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI", 7F);
            btnProfil.ForeColor = Color.Transparent;
            btnProfil.Location = new Point(287, 673);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(64, 56);
            btnProfil.TabIndex = 11;
            btnProfil.TabStop = false;
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += button1_Click;
            // 
            // lblMenunggu
            // 
            lblMenunggu.AutoSize = true;
            lblMenunggu.Location = new Point(174, 217);
            lblMenunggu.Name = "lblMenunggu";
            lblMenunggu.Size = new Size(17, 20);
            lblMenunggu.TabIndex = 0;
            lblMenunggu.Text = "0";
            // 
            // FrmPengelola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 741);
            Controls.Add(lblMenunggu);
            Controls.Add(lblDiterima);
            Controls.Add(lblDitolak);
            Controls.Add(btnProfil);
            Controls.Add(btnKelola);
            Controls.Add(btnStatistik);
            Controls.Add(btnverifikasi);
            Controls.Add(lblNama);
            DoubleBuffered = true;
            Name = "FrmPengelola";
            RightToLeft = RightToLeft.No;
            Text = "FrmPengelola";
            Load += FrmPengelola_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNama;
        private Label lblDiterima;
        private Label lblDitolak;
        private Button btnverifikasi;
        private Button btnStatistik;
        private Button btnKelola;
        private Button btnProfil;
        private Label lblMenunggu;
    }
}