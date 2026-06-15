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
            ((System.ComponentModel.ISupportInitialize)dgvKategori).BeginInit();
            SuspendLayout();
            // 
            // dgvKategori
            // 
            dgvKategori.AllowUserToAddRows = false;
            dgvKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            btnTambah.Location = new Point(27, 261);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(81, 29);
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
            btnEdit.Size = new Size(68, 29);
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
            btnHapus.Location = new Point(114, 261);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(72, 29);
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
            btnRefresh.Size = new Size(77, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.TabStop = false;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtKategori
            // 
            txtKategori.BorderStyle = BorderStyle.None;
            txtKategori.Location = new Point(40, 222);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(315, 20);
            txtKategori.TabIndex = 6;
            // 
            // btnKeProfil
            // 
            btnKeProfil.BackColor = Color.Transparent;
            btnKeProfil.FlatAppearance.BorderSize = 0;
            btnKeProfil.FlatStyle = FlatStyle.Flat;
            btnKeProfil.Location = new Point(285, 678);
            btnKeProfil.Name = "btnKeProfil";
            btnKeProfil.Size = new Size(72, 51);
            btnKeProfil.TabIndex = 22;
            btnKeProfil.UseVisualStyleBackColor = false;
            btnKeProfil.Click += btnKeProfil_Click;
            // 
            // btnKeStatistik
            // 
            btnKeStatistik.BackColor = Color.Transparent;
            btnKeStatistik.FlatAppearance.BorderSize = 0;
            btnKeStatistik.FlatStyle = FlatStyle.Flat;
            btnKeStatistik.Location = new Point(194, 678);
            btnKeStatistik.Name = "btnKeStatistik";
            btnKeStatistik.Size = new Size(72, 51);
            btnKeStatistik.TabIndex = 21;
            btnKeStatistik.UseVisualStyleBackColor = false;
            btnKeStatistik.Click += btnKeStatistik_Click;
            // 
            // btnKeKelola
            // 
            btnKeKelola.BackColor = Color.Transparent;
            btnKeKelola.FlatAppearance.BorderSize = 0;
            btnKeKelola.FlatStyle = FlatStyle.Flat;
            btnKeKelola.Location = new Point(116, 678);
            btnKeKelola.Name = "btnKeKelola";
            btnKeKelola.Size = new Size(72, 51);
            btnKeKelola.TabIndex = 20;
            btnKeKelola.UseVisualStyleBackColor = false;
            btnKeKelola.Click += btnKeKelola_Click;
            // 
            // btnKeVerifikasi
            // 
            btnKeVerifikasi.BackColor = Color.Transparent;
            btnKeVerifikasi.FlatAppearance.BorderSize = 0;
            btnKeVerifikasi.FlatStyle = FlatStyle.Flat;
            btnKeVerifikasi.Location = new Point(23, 678);
            btnKeVerifikasi.Name = "btnKeVerifikasi";
            btnKeVerifikasi.Size = new Size(85, 51);
            btnKeVerifikasi.TabIndex = 19;
            btnKeVerifikasi.UseVisualStyleBackColor = false;
            btnKeVerifikasi.Click += btnKeVerifikasi_Click;
            // 
            // FrmKelolaKategori
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
    }
}