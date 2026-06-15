namespace ProjekPbo.View
{
    partial class FrmRiwayatDonasi
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
            btnRefresh = new Button();
            btnKembali = new Button();
            flpRiwayat = new FlowLayoutPanel();
            btnSemua = new Button();
            btnDiterima = new Button();
            btnDitolak = new Button();
            btnMenunggu = new Button();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(278, 623);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(266, 695);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 2;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // flpRiwayat
            // 
            flpRiwayat.AutoScroll = true;
            flpRiwayat.FlowDirection = FlowDirection.TopDown;
            flpRiwayat.Location = new Point(-1, 200);
            flpRiwayat.Name = "flpRiwayat";
            flpRiwayat.Size = new Size(385, 356);
            flpRiwayat.TabIndex = 3;
            flpRiwayat.WrapContents = false;
            // 
            // btnSemua
            // 
            btnSemua.Location = new Point(-1, 165);
            btnSemua.Name = "btnSemua";
            btnSemua.Size = new Size(94, 29);
            btnSemua.TabIndex = 4;
            btnSemua.Text = "Semua";
            btnSemua.UseVisualStyleBackColor = true;
            btnSemua.Click += btnSemua_Click;
            // 
            // btnDiterima
            // 
            btnDiterima.Location = new Point(99, 165);
            btnDiterima.Name = "btnDiterima";
            btnDiterima.Size = new Size(94, 29);
            btnDiterima.TabIndex = 5;
            btnDiterima.Text = "Diterima";
            btnDiterima.UseVisualStyleBackColor = true;
            btnDiterima.Click += btnDiterima_Click;
            // 
            // btnDitolak
            // 
            btnDitolak.Location = new Point(190, 165);
            btnDitolak.Name = "btnDitolak";
            btnDitolak.Size = new Size(94, 29);
            btnDitolak.TabIndex = 6;
            btnDitolak.Text = "Ditolak";
            btnDitolak.UseVisualStyleBackColor = true;
            btnDitolak.Click += btnDitolak_Click;
            // 
            // btnMenunggu
            // 
            btnMenunggu.Location = new Point(290, 165);
            btnMenunggu.Name = "btnMenunggu";
            btnMenunggu.Size = new Size(94, 29);
            btnMenunggu.TabIndex = 7;
            btnMenunggu.Text = "menunggu";
            btnMenunggu.UseVisualStyleBackColor = true;
            btnMenunggu.Click += btnMenunggu_Click;
            // 
            // FrmRiwayatDonasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 741);
            Controls.Add(btnMenunggu);
            Controls.Add(btnDitolak);
            Controls.Add(btnDiterima);
            Controls.Add(btnSemua);
            Controls.Add(flpRiwayat);
            Controls.Add(btnKembali);
            Controls.Add(btnRefresh);
            Name = "FrmRiwayatDonasi";
            Text = "FrmRiwayatDonasi";
            Load += FrmRiwayatDonasi_Load_1;
            ResumeLayout(false);
        }

        #endregion
        private Button btnRefresh;
        private Button btnKembali;
        private FlowLayoutPanel flpRiwayat;
        private Button btnSemua;
        private Button btnDiterima;
        private Button btnDitolak;
        private Button btnMenunggu;
    }
}