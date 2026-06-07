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
            dgvKategori = new DataGridView();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnRefresh = new Button();
            btnKembali = new Button();
            txtKategori = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvKategori).BeginInit();
            SuspendLayout();
            // 
            // dgvKategori
            // 
            dgvKategori.AllowUserToAddRows = false;
            dgvKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategori.Location = new Point(12, 45);
            dgvKategori.MultiSelect = false;
            dgvKategori.Name = "dgvKategori";
            dgvKategori.ReadOnly = true;
            dgvKategori.RowHeadersWidth = 51;
            dgvKategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategori.Size = new Size(400, 233);
            dgvKategori.TabIndex = 0;
            dgvKategori.CellClick += dgvKategori_CellClick;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(12, 319);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(112, 319);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(212, 319);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 3;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(318, 319);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(159, 386);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 5;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(12, 286);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(400, 27);
            txtKategori.TabIndex = 6;
            // 
            // FrmKelolaKategori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 450);
            Controls.Add(txtKategori);
            Controls.Add(btnKembali);
            Controls.Add(btnRefresh);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnTambah);
            Controls.Add(dgvKategori);
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
        private Button btnKembali;
        private TextBox txtKategori;
    }
}