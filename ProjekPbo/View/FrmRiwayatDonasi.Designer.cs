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
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(51, 333);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(51, 378);
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
            flpRiwayat.Location = new Point(40, 12);
            flpRiwayat.Name = "flpRiwayat";
            flpRiwayat.Size = new Size(347, 315);
            flpRiwayat.TabIndex = 3;
            flpRiwayat.WrapContents = false;
            // 
            // FrmRiwayatDonasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 450);
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
    }
}