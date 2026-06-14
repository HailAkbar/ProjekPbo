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
            // FrmKelolaKategori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 741);
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
    }
}