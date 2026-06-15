namespace ProjekPbo.View
{
    partial class FrmDaftarBarangPengelola
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
            txtCari = new TextBox();
            btnCari = new Button();
            btnRefresh = new Button();
            btnKembali = new Button();
            flpBarang = new FlowLayoutPanel();
            btnKeVerifikasi = new Button();
            btnKeKelola = new Button();
            btnKeStatistik = new Button();
            btnKeProfil = new Button();
            SuspendLayout();
            // 
            // txtCari
            // 
            txtCari.BorderStyle = BorderStyle.None;
            txtCari.Location = new Point(40, 133);
            txtCari.Multiline = true;
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(300, 31);
            txtCari.TabIndex = 0;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.Transparent;
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCari.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.ForeColor = Color.Transparent;
            btnCari.Location = new Point(40, 182);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(78, 29);
            btnCari.TabIndex = 1;
            btnCari.TabStop = false;
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.Transparent;
            btnRefresh.Location = new Point(145, 182);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.TabStop = false;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKembali.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.ForeColor = Color.Transparent;
            btnKembali.Location = new Point(266, 182);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(88, 29);
            btnKembali.TabIndex = 3;
            btnKembali.TabStop = false;
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // flpBarang
            // 
            flpBarang.AutoScroll = true;
            flpBarang.BackColor = SystemColors.Window;
            flpBarang.Location = new Point(-1, 232);
            flpBarang.Name = "flpBarang";
            flpBarang.Size = new Size(389, 431);
            flpBarang.TabIndex = 4;
            // 
            // btnKeVerifikasi
            // 
            btnKeVerifikasi.BackColor = Color.Transparent;
            btnKeVerifikasi.FlatAppearance.BorderSize = 0;
            btnKeVerifikasi.FlatStyle = FlatStyle.Flat;
            btnKeVerifikasi.Location = new Point(20, 678);
            btnKeVerifikasi.Name = "btnKeVerifikasi";
            btnKeVerifikasi.Size = new Size(85, 51);
            btnKeVerifikasi.TabIndex = 5;
            btnKeVerifikasi.UseVisualStyleBackColor = false;
            btnKeVerifikasi.Click += btnKeVerifikasi_Click;
            // 
            // btnKeKelola
            // 
            btnKeKelola.BackColor = Color.Transparent;
            btnKeKelola.FlatAppearance.BorderSize = 0;
            btnKeKelola.FlatStyle = FlatStyle.Flat;
            btnKeKelola.Location = new Point(113, 678);
            btnKeKelola.Name = "btnKeKelola";
            btnKeKelola.Size = new Size(72, 51);
            btnKeKelola.TabIndex = 6;
            btnKeKelola.UseVisualStyleBackColor = false;
            btnKeKelola.Click += btnKeKelola_Click;
            // 
            // btnKeStatistik
            // 
            btnKeStatistik.BackColor = Color.Transparent;
            btnKeStatistik.FlatAppearance.BorderSize = 0;
            btnKeStatistik.FlatStyle = FlatStyle.Flat;
            btnKeStatistik.Location = new Point(191, 678);
            btnKeStatistik.Name = "btnKeStatistik";
            btnKeStatistik.Size = new Size(72, 51);
            btnKeStatistik.TabIndex = 7;
            btnKeStatistik.UseVisualStyleBackColor = false;
            btnKeStatistik.Click += btnKeStatistik_Click;
            // 
            // btnKeProfil
            // 
            btnKeProfil.BackColor = Color.Transparent;
            btnKeProfil.FlatAppearance.BorderSize = 0;
            btnKeProfil.FlatStyle = FlatStyle.Flat;
            btnKeProfil.Location = new Point(282, 678);
            btnKeProfil.Name = "btnKeProfil";
            btnKeProfil.Size = new Size(72, 51);
            btnKeProfil.TabIndex = 8;
            btnKeProfil.UseVisualStyleBackColor = false;
            btnKeProfil.Click += btnKeProfil_Click;
            // 
            // FrmDaftarBarangPengelola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pengelola__Verifikasi__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 741);
            Controls.Add(btnKeProfil);
            Controls.Add(btnKeStatistik);
            Controls.Add(btnKeKelola);
            Controls.Add(btnKeVerifikasi);
            Controls.Add(btnRefresh);
            Controls.Add(flpBarang);
            Controls.Add(btnKembali);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            DoubleBuffered = true;
            Name = "FrmDaftarBarangPengelola";
            Text = "FrmDaftarBarangPengelola";
            Load += FrmDaftarBarangPengelola_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCari;
        private Button btnCari;
        private Button btnRefresh;
        private Button btnKembali;
        private FlowLayoutPanel flpBarang;
        private Button btnKeVerifikasi;
        private Button btnKeKelola;
        private Button btnKeStatistik;
        private Button btnKeProfil;
    }
}