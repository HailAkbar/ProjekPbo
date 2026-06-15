namespace ProjekPbo.View
{
    partial class FrmStatistikPengelola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistikPengelola));
            btnRefresh = new Button();
            flpStatus = new FlowLayoutPanel();
            flpKategori = new FlowLayoutPanel();
            btnKeProfil = new Button();
            btnKeStatistik = new Button();
            btnKeKelola = new Button();
            btnKeVerifikasi = new Button();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(142, 116);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(111, 38);
            btnRefresh.TabIndex = 2;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // flpStatus
            // 
            flpStatus.AutoScroll = true;
            flpStatus.Location = new Point(29, 160);
            flpStatus.Name = "flpStatus";
            flpStatus.Size = new Size(327, 264);
            flpStatus.TabIndex = 4;
            // 
            // flpKategori
            // 
            flpKategori.AutoScroll = true;
            flpKategori.Location = new Point(29, 464);
            flpKategori.Name = "flpKategori";
            flpKategori.Size = new Size(327, 175);
            flpKategori.TabIndex = 5;
            // 
            // btnKeProfil
            // 
            btnKeProfil.BackColor = Color.Transparent;
            btnKeProfil.FlatAppearance.BorderSize = 0;
            btnKeProfil.FlatStyle = FlatStyle.Flat;
            btnKeProfil.Location = new Point(291, 678);
            btnKeProfil.Name = "btnKeProfil";
            btnKeProfil.Size = new Size(65, 51);
            btnKeProfil.TabIndex = 18;
            btnKeProfil.UseVisualStyleBackColor = false;
            btnKeProfil.Click += btnKeProfil_Click;
            // 
            // btnKeStatistik
            // 
            btnKeStatistik.BackColor = Color.Transparent;
            btnKeStatistik.FlatAppearance.BorderSize = 0;
            btnKeStatistik.FlatStyle = FlatStyle.Flat;
            btnKeStatistik.Location = new Point(200, 678);
            btnKeStatistik.Name = "btnKeStatistik";
            btnKeStatistik.Size = new Size(65, 51);
            btnKeStatistik.TabIndex = 17;
            btnKeStatistik.UseVisualStyleBackColor = false;
            btnKeStatistik.Click += btnKeStatistik_Click;
            // 
            // btnKeKelola
            // 
            btnKeKelola.BackColor = Color.Transparent;
            btnKeKelola.FlatAppearance.BorderSize = 0;
            btnKeKelola.FlatStyle = FlatStyle.Flat;
            btnKeKelola.Location = new Point(122, 678);
            btnKeKelola.Name = "btnKeKelola";
            btnKeKelola.Size = new Size(56, 51);
            btnKeKelola.TabIndex = 16;
            btnKeKelola.UseVisualStyleBackColor = false;
            btnKeKelola.Click += btnKeKelola_Click;
            // 
            // btnKeVerifikasi
            // 
            btnKeVerifikasi.BackColor = Color.Transparent;
            btnKeVerifikasi.FlatAppearance.BorderSize = 0;
            btnKeVerifikasi.FlatStyle = FlatStyle.Flat;
            btnKeVerifikasi.Location = new Point(29, 678);
            btnKeVerifikasi.Name = "btnKeVerifikasi";
            btnKeVerifikasi.Size = new Size(73, 51);
            btnKeVerifikasi.TabIndex = 15;
            btnKeVerifikasi.UseVisualStyleBackColor = false;
            btnKeVerifikasi.Click += btnKeVerifikasi_Click;
            // 
            // FrmStatistikPengelola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 741);
            Controls.Add(btnKeProfil);
            Controls.Add(btnKeStatistik);
            Controls.Add(btnKeKelola);
            Controls.Add(btnKeVerifikasi);
            Controls.Add(flpKategori);
            Controls.Add(flpStatus);
            Controls.Add(btnRefresh);
            DoubleBuffered = true;
            Name = "FrmStatistikPengelola";
            Text = "FrmStatistikPengelola";
            Load += FrmStatistikPengelola_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnRefresh;
        private FlowLayoutPanel flpStatus;
        private FlowLayoutPanel flpKategori;
        private Button btnKeProfil;
        private Button btnKeStatistik;
        private Button btnKeKelola;
        private Button btnKeVerifikasi;
    }
}