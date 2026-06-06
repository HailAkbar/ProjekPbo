namespace ProjekPbo.View
{
    partial class FrmStatistikPengelola
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
            btnRefresh = new Button();
            btnKembali = new Button();
            flpStatus = new FlowLayoutPanel();
            flpKategori = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "STATISTIK";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(43, 308);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(150, 395);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // flpStatus
            // 
            flpStatus.AutoScroll = true;
            flpStatus.Location = new Point(43, 32);
            flpStatus.Name = "flpStatus";
            flpStatus.Size = new Size(330, 132);
            flpStatus.TabIndex = 4;
            // 
            // flpKategori
            // 
            flpKategori.AutoScroll = true;
            flpKategori.Location = new Point(43, 170);
            flpKategori.Name = "flpKategori";
            flpKategori.Size = new Size(330, 132);
            flpKategori.TabIndex = 5;
            // 
            // FrmStatistikPengelola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 450);
            Controls.Add(flpKategori);
            Controls.Add(flpStatus);
            Controls.Add(btnKembali);
            Controls.Add(btnRefresh);
            Controls.Add(label1);
            Name = "FrmStatistikPengelola";
            Text = "FrmStatistikPengelola";
            Load += FrmStatistikPengelola_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnRefresh;
        private Button btnKembali;
        private FlowLayoutPanel flpStatus;
        private FlowLayoutPanel flpKategori;
    }
}