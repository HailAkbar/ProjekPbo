namespace ProjekPbo.View
{
    partial class FrmKelolaKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKelolaKategori));
            dgvKategori = new DataGridView();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnRefresh = new Button();
            txtKategori = new TextBox();
            btnKeProfil = new Button();
            btnKeStatistik = new Button();
            btnKeKelola = new Button();
            btnKeVerifikasi = new Button();
            btnKeBeranda = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKategori).BeginInit();
            SuspendLayout();
            // 
            // dgvKategori
            // 
            dgvKategori.AllowUserToAddRows = false;
            dgvKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKategori.BackgroundColor = Color.White;
            dgvKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategori.Location = new Point(-2, 321);
            dgvKategori.MultiSelect = false;
            dgvKategori.Name = "dgvKategori";
            dgvKategori.ReadOnly = true;
            dgvKategori.RowHeadersWidth = 51;
            dgvKategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategori.Size = new Size(387, 341);
            dgvKategori.TabIndex = 0;
            dgvKategori.CellClick += dgvKategori_CellClick;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Transparent;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTambah.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.ForeColor = Color.Transparent;
            btnTambah.Location = new Point(50, 261);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(74, 37);
            btnTambah.TabIndex = 1;
            btnTambah.TabStop = false;
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.Transparent;
            btnEdit.Location = new Point(204, 261);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(68, 37);
            btnEdit.TabIndex = 2;
            btnEdit.TabStop = false;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Transparent;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHapus.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = Color.Transparent;
            btnHapus.Location = new Point(130, 261);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(68, 37);
            btnHapus.TabIndex = 3;
            btnHapus.TabStop = false;
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.Transparent;
            btnRefresh.Location = new Point(278, 261);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(67, 37);
            btnRefresh.TabIndex = 4;
            btnRefresh.TabStop = false;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtKategori
            // 
            txtKategori.BorderStyle = BorderStyle.None;
            txtKategori.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtKategori.Location = new Point(57, 222);
            txtKategori.Multiline = true;
            txtKategori.Name = "txtKategori";
            txtKategori.PlaceholderText = "Masukkan Kategori";
            txtKategori.Size = new Size(280, 27);
            txtKategori.TabIndex = 6;
            // 
            // btnKeProfil
            // 
            btnKeProfil.BackColor = Color.Transparent;
            btnKeProfil.FlatAppearance.BorderSize = 0;
            btnKeProfil.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeProfil.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeProfil.FlatStyle = FlatStyle.Flat;
            btnKeProfil.Location = new Point(311, 668);
            btnKeProfil.Name = "btnKeProfil";
            btnKeProfil.Size = new Size(46, 61);
            btnKeProfil.TabIndex = 22;
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
            btnKeStatistik.Location = new Point(244, 668);
            btnKeStatistik.Name = "btnKeStatistik";
            btnKeStatistik.Size = new Size(44, 61);
            btnKeStatistik.TabIndex = 21;
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
            btnKeKelola.Location = new Point(171, 668);
            btnKeKelola.Name = "btnKeKelola";
            btnKeKelola.Size = new Size(43, 61);
            btnKeKelola.TabIndex = 20;
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
            btnKeVerifikasi.Location = new Point(101, 668);
            btnKeVerifikasi.Name = "btnKeVerifikasi";
            btnKeVerifikasi.Size = new Size(39, 61);
            btnKeVerifikasi.TabIndex = 19;
            btnKeVerifikasi.UseVisualStyleBackColor = false;
            btnKeVerifikasi.Click += btnKeVerifikasi_Click;
            // 
            // btnKeBeranda
            // 
            btnKeBeranda.BackColor = Color.Transparent;
            btnKeBeranda.FlatAppearance.BorderSize = 0;
            btnKeBeranda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeBeranda.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeBeranda.FlatStyle = FlatStyle.Flat;
            btnKeBeranda.Location = new Point(26, 668);
            btnKeBeranda.Name = "btnKeBeranda";
            btnKeBeranda.Size = new Size(39, 61);
            btnKeBeranda.TabIndex = 23;
            btnKeBeranda.UseVisualStyleBackColor = false;
            btnKeBeranda.Click += btnKeBeranda_Click;
            // 
            // FrmKelolaKategori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(384, 741);
            Controls.Add(btnKeBeranda);
            Controls.Add(btnKeProfil);
            Controls.Add(btnKeStatistik);
            Controls.Add(btnKeKelola);
            Controls.Add(btnKeVerifikasi);
            Controls.Add(txtKategori);
            Controls.Add(btnRefresh);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnTambah);
            Controls.Add(dgvKategori);
            DoubleBuffered = true;
            Name = "FrmKelolaKategori";
            Text = "FrmKelolaKategori";
            Load += FrmKelolaKategori_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKategori).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKategori;
        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnRefresh;
        private TextBox txtKategori;
        private Button btnKeProfil;
        private Button btnKeStatistik;
        private Button btnKeKelola;
        private Button btnKeVerifikasi;
        private Button btnKeBeranda;
    }
}