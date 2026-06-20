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
            btnKeHome = new Button();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(134, 119);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 35);
            btnRefresh.TabIndex = 2;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // flpStatus
            // 
            flpStatus.AutoScroll = true;
            flpStatus.BackColor = Color.White;
            flpStatus.Location = new Point(45, 160);
            flpStatus.Name = "flpStatus";
            flpStatus.Size = new Size(290, 263);
            flpStatus.TabIndex = 4;
            // 
            // flpKategori
            // 
            flpKategori.AutoScroll = true;
            flpKategori.BackColor = Color.White;
            flpKategori.Location = new Point(45, 460);
            flpKategori.Name = "flpKategori";
            flpKategori.Size = new Size(292, 178);
            flpKategori.TabIndex = 5;
            // 
            // btnKeProfil
            // 
            btnKeProfil.BackColor = Color.Transparent;
            btnKeProfil.FlatAppearance.BorderSize = 0;
            btnKeProfil.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeProfil.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeProfil.FlatStyle = FlatStyle.Flat;
            btnKeProfil.Location = new Point(310, 666);
            btnKeProfil.Name = "btnKeProfil";
            btnKeProfil.Size = new Size(46, 63);
            btnKeProfil.TabIndex = 18;
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
            btnKeStatistik.Location = new Point(245, 672);
            btnKeStatistik.Name = "btnKeStatistik";
            btnKeStatistik.Size = new Size(40, 51);
            btnKeStatistik.TabIndex = 17;
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
            btnKeKelola.Location = new Point(172, 672);
            btnKeKelola.Name = "btnKeKelola";
            btnKeKelola.Size = new Size(43, 51);
            btnKeKelola.TabIndex = 16;
            btnKeKelola.UseVisualStyleBackColor = false;
            btnKeKelola.Click += btnKeKelola_Click;
            // 
            // btnKeVerifikasi
            // 
            btnKeVerifikasi.BackColor = Color.Transparent;
            btnKeVerifikasi.FlatAppearance.BorderSize = 0;
            btnKeVerifikasi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeVerifikasi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeVerifikasi.FlatStyle = FlatStyle.Flat;
            btnKeVerifikasi.Location = new Point(98, 672);
            btnKeVerifikasi.Name = "btnKeVerifikasi";
            btnKeVerifikasi.Size = new Size(42, 51);
            btnKeVerifikasi.TabIndex = 15;
            btnKeVerifikasi.UseVisualStyleBackColor = false;
            btnKeVerifikasi.Click += btnKeVerifikasi_Click;
            // 
            // btnKeHome
            // 
            btnKeHome.BackColor = Color.Transparent;
            btnKeHome.FlatAppearance.BorderSize = 0;
            btnKeHome.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeHome.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeHome.FlatStyle = FlatStyle.Flat;
            btnKeHome.Location = new Point(26, 672);
            btnKeHome.Name = "btnKeHome";
            btnKeHome.Size = new Size(42, 51);
            btnKeHome.TabIndex = 19;
            btnKeHome.UseVisualStyleBackColor = false;
            btnKeHome.Click += btnKeHome_Click;
            // 
            // FrmStatistikPengelola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(384, 741);
            Controls.Add(btnKeHome);
            Controls.Add(btnKeProfil);
            Controls.Add(btnKeStatistik);
            Controls.Add(btnKeKelola);
            Controls.Add(btnKeVerifikasi);
            Controls.Add(flpKategori);
            Controls.Add(flpStatus);
            Controls.Add(btnRefresh);
            DoubleBuffered = true;
            Name = "FrmStatistikPengelola";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REUSEHUB";
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
        private Button btnKeHome;
    }
}