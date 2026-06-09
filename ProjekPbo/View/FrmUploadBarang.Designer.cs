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
            btnKembaliKeHome = new Button();
            ((System.ComponentModel.ISupportInitialize)picFotoBarang).BeginInit();
            SuspendLayout();
            // 
            // cbKategori
            // 
            cbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(37, 48);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(151, 28);
            cbKategori.TabIndex = 0;
            cbKategori.Click += FrmUploadBarang_Load;
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Location = new Point(43, 97);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(125, 27);
            txtNamaBarang.TabIndex = 1;
            txtNamaBarang.TextChanged += txtNamaBarang_TextChanged;
            // 
            // rbBaik
            // 
            rbBaik.AutoSize = true;
            rbBaik.Location = new Point(46, 146);
            rbBaik.Name = "rbBaik";
            rbBaik.Size = new Size(58, 24);
            rbBaik.TabIndex = 2;
            rbBaik.TabStop = true;
            rbBaik.Text = "baik";
            rbBaik.UseVisualStyleBackColor = true;
            // 
            // rbCukup
            // 
            rbCukup.AutoSize = true;
            rbCukup.Location = new Point(169, 146);
            rbCukup.Name = "rbCukup";
            rbCukup.Size = new Size(69, 24);
            rbCukup.TabIndex = 3;
            rbCukup.TabStop = true;
            rbCukup.Text = "cukub";
            rbCukup.UseVisualStyleBackColor = true;
            // 
            // rbRusak
            // 
            rbRusak.AutoSize = true;
            rbRusak.Location = new Point(292, 146);
            rbRusak.Name = "rbRusak";
            rbRusak.Size = new Size(64, 24);
            rbRusak.TabIndex = 4;
            rbRusak.TabStop = true;
            rbRusak.Text = "rusak";
            rbRusak.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(52, 180);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(307, 82);
            txtDeskripsi.TabIndex = 6;
            txtDeskripsi.Text = "";
            // 
            // picFotoBarang
            // 
            picFotoBarang.BorderStyle = BorderStyle.FixedSingle;
            picFotoBarang.Location = new Point(52, 268);
            picFotoBarang.Name = "picFotoBarang";
            picFotoBarang.Size = new Size(136, 70);
            picFotoBarang.SizeMode = PictureBoxSizeMode.Zoom;
            picFotoBarang.TabIndex = 7;
            picFotoBarang.TabStop = false;
            // 
            // btnPilihFoto
            // 
            btnPilihFoto.Location = new Point(194, 296);
            btnPilihFoto.Name = "btnPilihFoto";
            btnPilihFoto.Size = new Size(94, 29);
            btnPilihFoto.TabIndex = 8;
            btnPilihFoto.Text = "pilih poto";
            btnPilihFoto.UseVisualStyleBackColor = true;
            btnPilihFoto.Click += btnPilihFoto_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(244, 378);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnKembaliKeHome
            // 
            btnKembaliKeHome.Location = new Point(63, 378);
            btnKembaliKeHome.Name = "btnKembaliKeHome";
            btnKembaliKeHome.Size = new Size(94, 29);
            btnKembaliKeHome.TabIndex = 10;
            btnKembaliKeHome.Text = "Kembali";
            btnKembaliKeHome.UseVisualStyleBackColor = true;
            btnKembaliKeHome.Click += btnKembaliKeHome_Click;
            // 
            // FrmUploadBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 450);
            Controls.Add(btnKembaliKeHome);
            Controls.Add(btnSimpan);
            Controls.Add(btnPilihFoto);
            Controls.Add(picFotoBarang);
            Controls.Add(txtDeskripsi);
            Controls.Add(rbRusak);
            Controls.Add(rbCukup);
            Controls.Add(rbBaik);
            Controls.Add(txtNamaBarang);
            Controls.Add(cbKategori);
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
        private Button btnKembaliKeHome;
    }
}