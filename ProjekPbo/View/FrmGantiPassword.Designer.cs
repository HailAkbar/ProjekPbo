namespace ProjekPbo.View
{
    partial class FrmGantiPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGantiPassword));
            txtPasswordLama = new TextBox();
            txtPasswordBaru = new TextBox();
            txtKonfirmasi = new TextBox();
            btnSimpan = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // txtPasswordLama
            // 
            txtPasswordLama.BorderStyle = BorderStyle.None;
            txtPasswordLama.Font = new Font("Inter Medium", 9F, FontStyle.Bold);
            txtPasswordLama.Location = new Point(51, 202);
            txtPasswordLama.Multiline = true;
            txtPasswordLama.Name = "txtPasswordLama";
            txtPasswordLama.PlaceholderText = "Masukkan Password Lama";
            txtPasswordLama.Size = new Size(286, 29);
            txtPasswordLama.TabIndex = 5;
            // 
            // txtPasswordBaru
            // 
            txtPasswordBaru.BorderStyle = BorderStyle.None;
            txtPasswordBaru.Font = new Font("Inter Medium", 9F, FontStyle.Bold);
            txtPasswordBaru.Location = new Point(51, 294);
            txtPasswordBaru.Multiline = true;
            txtPasswordBaru.Name = "txtPasswordBaru";
            txtPasswordBaru.PlaceholderText = "Masukkan Password Baru";
            txtPasswordBaru.Size = new Size(286, 32);
            txtPasswordBaru.TabIndex = 6;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.BorderStyle = BorderStyle.None;
            txtKonfirmasi.Font = new Font("Inter Medium", 9F, FontStyle.Bold);
            txtKonfirmasi.Location = new Point(51, 389);
            txtKonfirmasi.Multiline = true;
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.PlaceholderText = "Konfirmasi Password Baru";
            txtKonfirmasi.Size = new Size(286, 31);
            txtKonfirmasi.TabIndex = 7;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Inter ExtraBold", 10.8F, FontStyle.Bold);
            btnSimpan.Location = new Point(197, 440);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(145, 58);
            btnSimpan.TabIndex = 11;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Inter ExtraBold", 10.8F, FontStyle.Bold);
            btnKembali.Location = new Point(44, 440);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(145, 58);
            btnKembali.TabIndex = 10;
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FrmGantiPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(384, 741);
            Controls.Add(btnSimpan);
            Controls.Add(btnKembali);
            Controls.Add(txtKonfirmasi);
            Controls.Add(txtPasswordBaru);
            Controls.Add(txtPasswordLama);
            Name = "FrmGantiPassword";
            Text = "FrmGantiPassword";
            Load += FrmGantiPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPasswordLama;
        private TextBox txtPasswordBaru;
        private TextBox txtKonfirmasi;
        private Button btnSimpan;
        private Button btnKembali;
    }
}