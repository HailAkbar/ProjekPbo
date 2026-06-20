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
            ((System.ComponentModel.ISupportInitialize)picFotoBarang).BeginInit();
            SuspendLayout();
            // 
            // cbKategori
            // 
            cbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategori.FlatStyle = FlatStyle.Flat;
            cbKategori.Font = new Font("Inter Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(78, 127);
            cbKategori.Margin = new Padding(3, 2, 3, 2);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(258, 32);
            cbKategori.TabIndex = 0;
            cbKategori.Click += FrmUploadBarang_Load;
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.BorderStyle = BorderStyle.None;
            txtNamaBarang.Font = new Font("Inter Medium", 9F, FontStyle.Bold);
            txtNamaBarang.Location = new Point(47, 202);
            txtNamaBarang.Margin = new Padding(3, 2, 3, 2);
            txtNamaBarang.Multiline = true;
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(283, 32);
            txtNamaBarang.TabIndex = 1;
            // 
            // rbBaik
            // 
            rbBaik.AutoSize = true;
            rbBaik.BackColor = Color.Transparent;
            rbBaik.FlatStyle = FlatStyle.Flat;
            rbBaik.Location = new Point(47, 283);
            rbBaik.Margin = new Padding(3, 2, 3, 2);
            rbBaik.Name = "rbBaik";
            rbBaik.Size = new Size(16, 15);
            rbBaik.TabIndex = 2;
            rbBaik.TabStop = true;
            rbBaik.UseVisualStyleBackColor = false;
            // 
            // rbCukup
            // 
            rbCukup.AutoSize = true;
            rbCukup.BackColor = Color.Transparent;
            rbCukup.FlatStyle = FlatStyle.Flat;
            rbCukup.Location = new Point(158, 283);
            rbCukup.Margin = new Padding(3, 2, 3, 2);
            rbCukup.Name = "rbCukup";
            rbCukup.Size = new Size(16, 15);
            rbCukup.TabIndex = 3;
            rbCukup.TabStop = true;
            rbCukup.UseVisualStyleBackColor = false;
            // 
            // rbRusak
            // 
            rbRusak.AutoSize = true;
            rbRusak.BackColor = Color.Transparent;
            rbRusak.FlatStyle = FlatStyle.Flat;
            rbRusak.Location = new Point(274, 283);
            rbRusak.Margin = new Padding(3, 2, 3, 2);
            rbRusak.Name = "rbRusak";
            rbRusak.Size = new Size(16, 15);
            rbRusak.TabIndex = 4;
            rbRusak.TabStop = true;
            rbRusak.UseVisualStyleBackColor = false;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.BorderStyle = BorderStyle.None;
            txtDeskripsi.Font = new Font("Inter Medium", 9F, FontStyle.Bold);
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
            picFotoBarang.Location = new Point(40, 561);
            picFotoBarang.Margin = new Padding(3, 2, 3, 2);
            picFotoBarang.Name = "picFotoBarang";
            picFotoBarang.Size = new Size(65, 50);
            picFotoBarang.SizeMode = PictureBoxSizeMode.Zoom;
            picFotoBarang.TabIndex = 7;
            picFotoBarang.TabStop = false;
            // 
            // btnPilihFoto
            // 
            btnPilihFoto.BackColor = Color.Transparent;
            btnPilihFoto.FlatAppearance.BorderSize = 0;
            btnPilihFoto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPilihFoto.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPilihFoto.FlatStyle = FlatStyle.Flat;
            btnPilihFoto.Location = new Point(47, 473);
            btnPilihFoto.Margin = new Padding(3, 2, 3, 2);
            btnPilihFoto.Name = "btnPilihFoto";
            btnPilihFoto.Size = new Size(289, 71);
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
            btnSimpan.Font = new Font("Inter ExtraBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(40, 634);
            btnSimpan.Margin = new Padding(3, 2, 3, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(302, 36);
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
            btnKeProfil.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeProfil.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeProfil.FlatStyle = FlatStyle.Flat;
            btnKeProfil.Location = new Point(294, 676);
            btnKeProfil.Name = "btnKeProfil";
            btnKeProfil.Size = new Size(42, 53);
            btnKeProfil.TabIndex = 15;
            btnKeProfil.UseVisualStyleBackColor = false;
            btnKeProfil.Click += btnKeProfil_Click;
            // 
            // btnKeRiwayat
            // 
            btnKeRiwayat.BackColor = Color.Transparent;
            btnKeRiwayat.FlatAppearance.BorderSize = 0;
            btnKeRiwayat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeRiwayat.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeRiwayat.FlatStyle = FlatStyle.Flat;
            btnKeRiwayat.Location = new Point(169, 676);
            btnKeRiwayat.Name = "btnKeRiwayat";
            btnKeRiwayat.Size = new Size(53, 53);
            btnKeRiwayat.TabIndex = 14;
            btnKeRiwayat.UseVisualStyleBackColor = false;
            btnKeRiwayat.Click += btnKeRiwayat_Click;
            // 
            // btnKeUpload
            // 
            btnKeUpload.BackColor = Color.Transparent;
            btnKeUpload.FlatAppearance.BorderSize = 0;
            btnKeUpload.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeUpload.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeUpload.FlatStyle = FlatStyle.Flat;
            btnKeUpload.Location = new Point(47, 676);
            btnKeUpload.Name = "btnKeUpload";
            btnKeUpload.Size = new Size(52, 53);
            btnKeUpload.TabIndex = 13;
            btnKeUpload.UseVisualStyleBackColor = false;
            btnKeUpload.Click += btnKeUpload_Click;
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
    }
}