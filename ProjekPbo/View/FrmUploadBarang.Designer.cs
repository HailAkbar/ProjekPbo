namespace ProjekPbo.View
{
    partial class FrmUploadBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUploadBarang));
            cbKategori = new ComboBox();
            txtNamaBarang = new TextBox();
            rbBaik = new RadioButton();
            rbCukup = new RadioButton();
            rbRusak = new RadioButton();
            txtDeskripsi = new RichTextBox();
            picFotoBarang = new PictureBox();
            btnPilihFoto = new Button();
            btnSimpan = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnKeProfil = new Button();
            btnKeRiwayat = new Button();
            btnKeUpload = new Button();
            btnKeberanda = new Button();
            ((System.ComponentModel.ISupportInitialize)picFotoBarang).BeginInit();
            SuspendLayout();
            // 
            // cbKategori
            // 
            cbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategori.Font = new Font("Segoe UI", 12F);
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(47, 126);
            cbKategori.Margin = new Padding(3, 2, 3, 2);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(283, 36);
            cbKategori.TabIndex = 0;
            cbKategori.Click += FrmUploadBarang_Load;
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.BorderStyle = BorderStyle.None;
            txtNamaBarang.Location = new Point(47, 201);
            txtNamaBarang.Margin = new Padding(3, 2, 3, 2);
            txtNamaBarang.Multiline = true;
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(283, 33);
            txtNamaBarang.TabIndex = 1;
            // 
            // rbBaik
            // 
            rbBaik.AutoSize = true;
            rbBaik.BackColor = Color.Transparent;
            rbBaik.Location = new Point(47, 283);
            rbBaik.Margin = new Padding(3, 2, 3, 2);
            rbBaik.Name = "rbBaik";
            rbBaik.Size = new Size(17, 16);
            rbBaik.TabIndex = 2;
            rbBaik.TabStop = true;
            rbBaik.UseVisualStyleBackColor = false;
            // 
            // rbCukup
            // 
            rbCukup.AutoSize = true;
            rbCukup.BackColor = Color.Transparent;
            rbCukup.Location = new Point(158, 283);
            rbCukup.Margin = new Padding(3, 2, 3, 2);
            rbCukup.Name = "rbCukup";
            rbCukup.Size = new Size(17, 16);
            rbCukup.TabIndex = 3;
            rbCukup.TabStop = true;
            rbCukup.UseVisualStyleBackColor = false;
            // 
            // rbRusak
            // 
            rbRusak.AutoSize = true;
            rbRusak.BackColor = Color.Transparent;
            rbRusak.Location = new Point(274, 283);
            rbRusak.Margin = new Padding(3, 2, 3, 2);
            rbRusak.Name = "rbRusak";
            rbRusak.Size = new Size(17, 16);
            rbRusak.TabIndex = 4;
            rbRusak.TabStop = true;
            rbRusak.UseVisualStyleBackColor = false;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.BorderStyle = BorderStyle.None;
            txtDeskripsi.Location = new Point(47, 353);
            txtDeskripsi.Margin = new Padding(3, 2, 3, 2);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(289, 70);
            txtDeskripsi.TabIndex = 6;
            txtDeskripsi.Text = "";
            // 
            // picFotoBarang
            // 
            picFotoBarang.BorderStyle = BorderStyle.FixedSingle;
            picFotoBarang.Location = new Point(47, 562);
            picFotoBarang.Margin = new Padding(3, 2, 3, 2);
            picFotoBarang.Name = "picFotoBarang";
            picFotoBarang.Size = new Size(54, 47);
            picFotoBarang.SizeMode = PictureBoxSizeMode.Zoom;
            picFotoBarang.TabIndex = 7;
            picFotoBarang.TabStop = false;
            // 
            // btnPilihFoto
            // 
            btnPilihFoto.BackColor = Color.Transparent;
            btnPilihFoto.FlatAppearance.BorderSize = 0;
            btnPilihFoto.FlatStyle = FlatStyle.Flat;
            btnPilihFoto.Location = new Point(35, 472);
            btnPilihFoto.Margin = new Padding(3, 2, 3, 2);
            btnPilihFoto.Name = "btnPilihFoto";
            btnPilihFoto.Size = new Size(301, 76);
            btnPilihFoto.TabIndex = 8;
            btnPilihFoto.UseVisualStyleBackColor = false;
            btnPilihFoto.Click += btnPilihFoto_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.BackgroundImageLayout = ImageLayout.Stretch;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Location = new Point(35, 629);
            btnSimpan.Margin = new Padding(3, 2, 3, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(312, 42);
            btnSimpan.TabIndex = 9;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnKeProfil
            // 
            btnKeProfil.BackColor = Color.Transparent;
            btnKeProfil.FlatAppearance.BorderSize = 0;
            btnKeProfil.FlatStyle = FlatStyle.Flat;
            btnKeProfil.Location = new Point(277, 676);
            btnKeProfil.Name = "btnKeProfil";
            btnKeProfil.Size = new Size(71, 53);
            btnKeProfil.TabIndex = 15;
            btnKeProfil.UseVisualStyleBackColor = false;
            btnKeProfil.Click += btnKeProfil_Click;
            // 
            // btnKeRiwayat
            // 
            btnKeRiwayat.BackColor = Color.Transparent;
            btnKeRiwayat.FlatAppearance.BorderSize = 0;
            btnKeRiwayat.FlatStyle = FlatStyle.Flat;
            btnKeRiwayat.Location = new Point(200, 676);
            btnKeRiwayat.Name = "btnKeRiwayat";
            btnKeRiwayat.Size = new Size(71, 53);
            btnKeRiwayat.TabIndex = 14;
            btnKeRiwayat.UseVisualStyleBackColor = false;
            btnKeRiwayat.Click += btnKeRiwayat_Click;
            // 
            // btnKeUpload
            // 
            btnKeUpload.BackColor = Color.Transparent;
            btnKeUpload.FlatAppearance.BorderSize = 0;
            btnKeUpload.FlatStyle = FlatStyle.Flat;
            btnKeUpload.Location = new Point(123, 676);
            btnKeUpload.Name = "btnKeUpload";
            btnKeUpload.Size = new Size(59, 53);
            btnKeUpload.TabIndex = 13;
            btnKeUpload.UseVisualStyleBackColor = false;
            btnKeUpload.Click += btnKeUpload_Click;
            // 
            // btnKeberanda
            // 
            btnKeberanda.BackColor = Color.Transparent;
            btnKeberanda.FlatAppearance.BorderSize = 0;
            btnKeberanda.FlatStyle = FlatStyle.Flat;
            btnKeberanda.Location = new Point(34, 676);
            btnKeberanda.Name = "btnKeberanda";
            btnKeberanda.Size = new Size(60, 53);
            btnKeberanda.TabIndex = 12;
            btnKeberanda.UseVisualStyleBackColor = false;
            btnKeberanda.Click += btnKeberanda_Click;
            // 
            // FrmUploadBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 741);
            Controls.Add(btnKeProfil);
            Controls.Add(btnKeRiwayat);
            Controls.Add(btnKeUpload);
            Controls.Add(btnKeberanda);
            Controls.Add(btnSimpan);
            Controls.Add(btnPilihFoto);
            Controls.Add(picFotoBarang);
            Controls.Add(txtDeskripsi);
            Controls.Add(rbRusak);
            Controls.Add(rbCukup);
            Controls.Add(rbBaik);
            Controls.Add(txtNamaBarang);
            Controls.Add(cbKategori);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmUploadBarang";
            Text = "UploadBarang";
            Load += FrmUploadBarang_Load;
            ((System.ComponentModel.ISupportInitialize)picFotoBarang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbKategori;
        private TextBox txtNamaBarang;
        private RadioButton rbBaik;
        private RadioButton rbCukup;
        private RadioButton rbRusak;
        private RichTextBox txtDeskripsi;
        private PictureBox picFotoBarang;
        private Button btnPilihFoto;
        private Button btnSimpan;
        private OpenFileDialog openFileDialog1;
        private Button btnKeProfil;
        private Button btnKeRiwayat;
        private Button btnKeUpload;
        private Button btnKeberanda;
    }
}