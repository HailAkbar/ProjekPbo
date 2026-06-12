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
            ((System.ComponentModel.ISupportInitialize)picFotoBarang).BeginInit();
            SuspendLayout();
            // 
            // cbKategori
            // 
            cbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(45, 133);
            cbKategori.Margin = new Padding(3, 2, 3, 2);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(295, 23);
            cbKategori.TabIndex = 0;
            cbKategori.Click += FrmUploadBarang_Load;
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Location = new Point(45, 204);
            txtNamaBarang.Margin = new Padding(3, 2, 3, 2);
            txtNamaBarang.Multiline = true;
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(297, 34);
            txtNamaBarang.TabIndex = 1;
            txtNamaBarang.TextChanged += txtNamaBarang_TextChanged;
            // 
            // rbBaik
            // 
            rbBaik.AutoSize = true;
            rbBaik.Location = new Point(48, 285);
            rbBaik.Margin = new Padding(3, 2, 3, 2);
            rbBaik.Name = "rbBaik";
            rbBaik.Size = new Size(47, 19);
            rbBaik.TabIndex = 2;
            rbBaik.TabStop = true;
            rbBaik.Text = "baik";
            rbBaik.UseVisualStyleBackColor = true;
            // 
            // rbCukup
            // 
            rbCukup.AutoSize = true;
            rbCukup.Location = new Point(159, 285);
            rbCukup.Margin = new Padding(3, 2, 3, 2);
            rbCukup.Name = "rbCukup";
            rbCukup.Size = new Size(58, 19);
            rbCukup.TabIndex = 3;
            rbCukup.TabStop = true;
            rbCukup.Text = "cukub";
            rbCukup.UseVisualStyleBackColor = true;
            // 
            // rbRusak
            // 
            rbRusak.AutoSize = true;
            rbRusak.Location = new Point(275, 285);
            rbRusak.Margin = new Padding(3, 2, 3, 2);
            rbRusak.Name = "rbRusak";
            rbRusak.Size = new Size(53, 19);
            rbRusak.TabIndex = 4;
            rbRusak.TabStop = true;
            rbRusak.Text = "rusak";
            rbRusak.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(43, 356);
            txtDeskripsi.Margin = new Padding(3, 2, 3, 2);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(297, 75);
            txtDeskripsi.TabIndex = 6;
            txtDeskripsi.Text = "";
            // 
            // picFotoBarang
            // 
            picFotoBarang.BorderStyle = BorderStyle.FixedSingle;
            picFotoBarang.Location = new Point(44, 569);
            picFotoBarang.Margin = new Padding(3, 2, 3, 2);
            picFotoBarang.Name = "picFotoBarang";
            picFotoBarang.Size = new Size(56, 45);
            picFotoBarang.SizeMode = PictureBoxSizeMode.Zoom;
            picFotoBarang.TabIndex = 7;
            picFotoBarang.TabStop = false;
            // 
            // btnPilihFoto
            // 
            btnPilihFoto.Location = new Point(43, 478);
            btnPilihFoto.Margin = new Padding(3, 2, 3, 2);
            btnPilihFoto.Name = "btnPilihFoto";
            btnPilihFoto.Size = new Size(298, 74);
            btnPilihFoto.TabIndex = 8;
            btnPilihFoto.Text = "pilih poto";
            btnPilihFoto.UseVisualStyleBackColor = true;
            btnPilihFoto.Click += btnPilihFoto_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackgroundImageLayout = ImageLayout.Stretch;
            btnSimpan.Location = new Point(44, 641);
            btnSimpan.Margin = new Padding(3, 2, 3, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(296, 34);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmUploadBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(386, 749);
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
    }
}