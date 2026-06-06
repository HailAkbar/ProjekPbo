namespace ProjekPbo.View
{
    partial class FrmDaftarBarangPengelola
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
            txtCari = new TextBox();
            btnCari = new Button();
            btnRefresh = new Button();
            btnKembali = new Button();
            flpBarang = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // txtCari
            // 
            txtCari.Location = new Point(97, 31);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(223, 27);
            txtCari.TabIndex = 0;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(158, 64);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(94, 29);
            btnCari.TabIndex = 1;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(61, 391);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(302, 391);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // flpBarang
            // 
            flpBarang.AutoScroll = true;
            flpBarang.Location = new Point(12, 99);
            flpBarang.Name = "flpBarang";
            flpBarang.Size = new Size(416, 286);
            flpBarang.TabIndex = 4;
            // 
            // FrmDaftarBarangPengelola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(flpBarang);
            Controls.Add(btnKembali);
            Controls.Add(btnRefresh);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Name = "FrmDaftarBarangPengelola";
            Text = "FrmDaftarBarangPengelola";
            Load += FrmDaftarBarangPengelola_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCari;
        private Button btnCari;
        private Button btnRefresh;
        private Button btnKembali;
        private FlowLayoutPanel flpBarang;
    }
}