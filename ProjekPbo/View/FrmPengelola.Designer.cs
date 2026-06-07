namespace ProjekPbo.View
{
    partial class FrmPengelola
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
            label1 = new Label();
            lblNama = new Label();
            panel1 = new Panel();
            lblMenunggu = new Label();
            panel2 = new Panel();
            lblDiterima = new Label();
            panel3 = new Panel();
            lblDitolak = new Label();
            panel4 = new Panel();
            lblSelesai = new Label();
            btnverifikasi = new Button();
            btnStatistik = new Button();
            btnKelola = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 54);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Halo,";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(245, 54);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(53, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "NAMA";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMenunggu);
            panel1.Location = new Point(46, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 49);
            panel1.TabIndex = 6;
            // 
            // lblMenunggu
            // 
            lblMenunggu.AutoSize = true;
            lblMenunggu.Location = new Point(16, 17);
            lblMenunggu.Name = "lblMenunggu";
            lblMenunggu.Size = new Size(50, 20);
            lblMenunggu.TabIndex = 0;
            lblMenunggu.Text = "label2";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDiterima);
            panel2.Location = new Point(46, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 49);
            panel2.TabIndex = 7;
            // 
            // lblDiterima
            // 
            lblDiterima.AutoSize = true;
            lblDiterima.Location = new Point(16, 15);
            lblDiterima.Name = "lblDiterima";
            lblDiterima.Size = new Size(50, 20);
            lblDiterima.TabIndex = 1;
            lblDiterima.Text = "label3";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblDitolak);
            panel3.Location = new Point(46, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 49);
            panel3.TabIndex = 7;
            // 
            // lblDitolak
            // 
            lblDitolak.AutoSize = true;
            lblDitolak.Location = new Point(16, 14);
            lblDitolak.Name = "lblDitolak";
            lblDitolak.Size = new Size(50, 20);
            lblDitolak.TabIndex = 2;
            lblDitolak.Text = "label4";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblSelesai);
            panel4.Location = new Point(46, 255);
            panel4.Name = "panel4";
            panel4.Size = new Size(178, 49);
            panel4.TabIndex = 7;
            // 
            // lblSelesai
            // 
            lblSelesai.AutoSize = true;
            lblSelesai.Location = new Point(16, 13);
            lblSelesai.Name = "lblSelesai";
            lblSelesai.Size = new Size(50, 20);
            lblSelesai.TabIndex = 3;
            lblSelesai.Text = "label5";
            // 
            // btnverifikasi
            // 
            btnverifikasi.Location = new Point(46, 381);
            btnverifikasi.Name = "btnverifikasi";
            btnverifikasi.Size = new Size(94, 29);
            btnverifikasi.TabIndex = 8;
            btnverifikasi.Text = "Verifikasi";
            btnverifikasi.UseVisualStyleBackColor = true;
            btnverifikasi.Click += btnVerifikasi_Click;
            // 
            // btnStatistik
            // 
            btnStatistik.Location = new Point(245, 381);
            btnStatistik.Name = "btnStatistik";
            btnStatistik.Size = new Size(94, 29);
            btnStatistik.TabIndex = 9;
            btnStatistik.Text = "Statistik";
            btnStatistik.UseVisualStyleBackColor = true;
            btnStatistik.Click += btnStatistik_Click;
            // 
            // btnKelola
            // 
            btnKelola.Location = new Point(146, 381);
            btnKelola.Name = "btnKelola";
            btnKelola.Size = new Size(94, 29);
            btnKelola.TabIndex = 10;
            btnKelola.Text = "Kelola";
            btnKelola.UseVisualStyleBackColor = true;
            btnKelola.Click += btnkelola_Click;
            // 
            // button1
            // 
            button1.Location = new Point(345, 381);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Profil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmPengelola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(button1);
            Controls.Add(btnKelola);
            Controls.Add(btnStatistik);
            Controls.Add(btnverifikasi);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblNama);
            Controls.Add(label1);
            Name = "FrmPengelola";
            Text = "FrmPengelola";
            Load += FrmPengelola_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNama;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblMenunggu;
        private Label lblDiterima;
        private Label lblDitolak;
        private Label lblSelesai;
        private Button btnverifikasi;
        private Button btnStatistik;
        private Button btnKelola;
        private Button button1;
    }
}