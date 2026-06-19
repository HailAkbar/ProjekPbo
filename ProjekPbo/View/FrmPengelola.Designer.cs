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
            lblMenunggu = new Label();
            btnkeBeranda = new Button();
            btnKeProfil = new Button();
            btnKeStatistik = new Button();
            btnKeKelola = new Button();
            btnkeVerifikasi = new Button();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.BackColor = Color.White;
            lblNama.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(57, 120);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(135, 35);
            lblNama.TabIndex = 1;
            lblNama.Text = "NAMA";
            // 
            // lblDiterima
            // 
            lblDiterima.AutoSize = true;
            lblDiterima.Font = new Font("Inter Medium", 10.2F, FontStyle.Bold);
            lblDiterima.Location = new Point(152, 287);
            lblDiterima.Name = "lblDiterima";
            lblDiterima.Size = new Size(21, 24);
            lblDiterima.TabIndex = 1;
            lblDiterima.Text = "0";
            // 
            // lblDitolak
            // 
            lblDitolak.AutoSize = true;
            lblDitolak.Font = new Font("Inter Medium", 10.2F, FontStyle.Bold);
            lblDitolak.Location = new Point(142, 358);
            lblDitolak.Name = "lblDitolak";
            lblDitolak.Size = new Size(21, 24);
            lblDitolak.TabIndex = 2;
            lblDitolak.Text = "0";
            // 
            // lblMenunggu
            // 
            lblMenunggu.AutoSize = true;
            lblMenunggu.Font = new Font("Inter Medium", 10.2F, FontStyle.Bold);
            lblMenunggu.Location = new Point(171, 213);
            lblMenunggu.Name = "lblMenunggu";
            lblMenunggu.Size = new Size(21, 24);
            lblMenunggu.TabIndex = 0;
            lblMenunggu.Text = "0";
            // 
            // btnkeBeranda
            // 
            btnkeBeranda.BackColor = Color.Transparent;
            btnkeBeranda.FlatAppearance.BorderSize = 0;
            btnkeBeranda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnkeBeranda.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnkeBeranda.FlatStyle = FlatStyle.Flat;
            btnkeBeranda.Location = new Point(32, 665);
            btnkeBeranda.Name = "btnkeBeranda";
            btnkeBeranda.Size = new Size(38, 67);
            btnkeBeranda.TabIndex = 25;
            btnkeBeranda.UseVisualStyleBackColor = false;
            btnkeBeranda.Click += btnkeBeranda_Click;
            // 
            // btnKeProfil
            // 
            btnKeProfil.BackColor = Color.Transparent;
            btnKeProfil.FlatAppearance.BorderSize = 0;
            btnKeProfil.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeProfil.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeProfil.FlatStyle = FlatStyle.Flat;
            btnKeProfil.Location = new Point(315, 665);
            btnKeProfil.Name = "btnKeProfil";
            btnKeProfil.Size = new Size(35, 59);
            btnKeProfil.TabIndex = 24;
            btnKeProfil.UseVisualStyleBackColor = false;
            btnKeProfil.Click += btnKeProfil_Click;
            // 
            // btnKeStatistik
            // 
            btnKeStatistik.BackColor = Color.Transparent;
            btnKeStatistik.FlatAppearance.BorderSize = 0;
            btnKeStatistik.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeStatistik.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeStatistik.FlatStyle = FlatStyle.Flat;
            btnKeStatistik.Location = new Point(248, 665);
            btnKeStatistik.Name = "btnKeStatistik";
            btnKeStatistik.Size = new Size(36, 59);
            btnKeStatistik.TabIndex = 23;
            btnKeStatistik.UseVisualStyleBackColor = false;
            btnKeStatistik.Click += btnKeStatistik_Click;
            // 
            // btnKeKelola
            // 
            btnKeKelola.BackColor = Color.Transparent;
            btnKeKelola.FlatAppearance.BorderSize = 0;
            btnKeKelola.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeKelola.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeKelola.FlatStyle = FlatStyle.Flat;
            btnKeKelola.Location = new Point(171, 665);
            btnKeKelola.Name = "btnKeKelola";
            btnKeKelola.Size = new Size(42, 59);
            btnKeKelola.TabIndex = 22;
            btnKeKelola.UseVisualStyleBackColor = false;
            btnKeKelola.Click += btnKeKelola_Click;
            // 
            // btnkeVerifikasi
            // 
            btnkeVerifikasi.BackColor = Color.Transparent;
            btnkeVerifikasi.FlatAppearance.BorderSize = 0;
            btnkeVerifikasi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnkeVerifikasi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnkeVerifikasi.FlatStyle = FlatStyle.Flat;
            btnkeVerifikasi.Font = new Font("Segoe UI", 7F);
            btnkeVerifikasi.ForeColor = Color.Transparent;
            btnkeVerifikasi.Location = new Point(103, 665);
            btnkeVerifikasi.Name = "btnkeVerifikasi";
            btnkeVerifikasi.Size = new Size(36, 64);
            btnkeVerifikasi.TabIndex = 21;
            btnkeVerifikasi.TabStop = false;
            btnkeVerifikasi.UseVisualStyleBackColor = true;
            btnkeVerifikasi.Click += btnKeVerifikasi_Click;
            // 
            // FrmPengelola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(384, 741);
            Controls.Add(btnkeBeranda);
            Controls.Add(btnKeProfil);
            Controls.Add(btnKeStatistik);
            Controls.Add(btnKeKelola);
            Controls.Add(btnkeVerifikasi);
            Controls.Add(lblMenunggu);
            Controls.Add(lblDiterima);
            Controls.Add(lblDitolak);
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
        private Label lblMenunggu;
        private Button btnKeVerifikasi;
        private Button btnkeBeranda;
        private Button btnKeProfil;
        private Button btnKeStatistik;
        private Button btnKeKelola;
        private Button btnkeVerifikasi;
    }
}