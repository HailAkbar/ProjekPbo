namespace ProjekPbo.View
{
    partial class FrmDetailVerifikasi
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
            picBarang = new PictureBox();
            lblNamaBarang = new Label();
            lblNamaDonatur = new Label();
            lblKategori = new Label();
            lblKondisi = new Label();
            lblTanggal = new Label();
            rtbDeskripsi = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtCatatan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picBarang).BeginInit();
            SuspendLayout();
            // 
            // picBarang
            // 
            picBarang.Location = new Point(129, 30);
            picBarang.Name = "picBarang";
            picBarang.Size = new Size(162, 68);
            picBarang.TabIndex = 0;
            picBarang.TabStop = false;
            // 
            // lblNamaBarang
            // 
            lblNamaBarang.AutoSize = true;
            lblNamaBarang.Location = new Point(51, 116);
            lblNamaBarang.Name = "lblNamaBarang";
            lblNamaBarang.Size = new Size(50, 20);
            lblNamaBarang.TabIndex = 1;
            lblNamaBarang.Text = "label1";
            // 
            // lblNamaDonatur
            // 
            lblNamaDonatur.AutoSize = true;
            lblNamaDonatur.Location = new Point(51, 147);
            lblNamaDonatur.Name = "lblNamaDonatur";
            lblNamaDonatur.Size = new Size(50, 20);
            lblNamaDonatur.TabIndex = 2;
            lblNamaDonatur.Text = "label2";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(51, 178);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(50, 20);
            lblKategori.TabIndex = 3;
            lblKategori.Text = "label3";
            // 
            // lblKondisi
            // 
            lblKondisi.AutoSize = true;
            lblKondisi.Location = new Point(51, 208);
            lblKondisi.Name = "lblKondisi";
            lblKondisi.Size = new Size(50, 20);
            lblKondisi.TabIndex = 4;
            lblKondisi.Text = "label4";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(51, 240);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(50, 20);
            lblTanggal.TabIndex = 5;
            lblTanggal.Text = "label5";
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Location = new Point(51, 273);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(348, 53);
            rtbDeskripsi.TabIndex = 6;
            rtbDeskripsi.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(74, 370);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "TERIMA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(305, 370);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "TOLAK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(177, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "KEMBALI";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtCatatan
            // 
            txtCatatan.Location = new Point(53, 331);
            txtCatatan.Name = "txtCatatan";
            txtCatatan.Size = new Size(238, 27);
            txtCatatan.TabIndex = 10;
            // 
            // FrmVerivikasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(txtCatatan);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rtbDeskripsi);
            Controls.Add(lblTanggal);
            Controls.Add(lblKondisi);
            Controls.Add(lblKategori);
            Controls.Add(lblNamaDonatur);
            Controls.Add(lblNamaBarang);
            Controls.Add(picBarang);
            Name = "FrmVerivikasi";
            Text = "FrmVerivikasi";
            Load += FrmVerivikasi_Load;
            ((System.ComponentModel.ISupportInitialize)picBarang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBarang;
        private Label lblNama;
        private Label lblNamaDonatur;
        private Label lblKategori;
        private Label lblKondisi;
        private Label lblTanggal;
        private RichTextBox rtbDeskripsi;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblNamaBarang;
        private TextBox txtCatatan;
    }
}