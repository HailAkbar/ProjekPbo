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
            btnSimpan = new Button();
            btnKembali = new Button();
            txtPasswordLama = new TextBox();
            txtPasswordBaru = new TextBox();
            txtKonfirmasi = new TextBox();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSimpan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Location = new Point(194, 442);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(153, 56);
            btnSimpan.TabIndex = 0;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKembali.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Location = new Point(42, 442);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(146, 56);
            btnKembali.TabIndex = 4;
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // txtPasswordLama
            // 
            txtPasswordLama.BorderStyle = BorderStyle.None;
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
            txtPasswordBaru.Location = new Point(51, 289);
            txtPasswordBaru.Multiline = true;
            txtPasswordBaru.Name = "txtPasswordBaru";
            txtPasswordBaru.PlaceholderText = "Masukkan Password Baru";
            txtPasswordBaru.Size = new Size(286, 35);
            txtPasswordBaru.TabIndex = 6;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.BorderStyle = BorderStyle.None;
            txtKonfirmasi.Location = new Point(51, 383);
            txtKonfirmasi.Multiline = true;
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.PlaceholderText = "Konfirmasi Password Baru";
            txtKonfirmasi.Size = new Size(286, 37);
            txtKonfirmasi.TabIndex = 7;
            txtKonfirmasi.TextChanged += txtKonfirmasi_TextChanged;
            // 
            // FrmGantiPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 741);
            Controls.Add(txtKonfirmasi);
            Controls.Add(txtPasswordBaru);
            Controls.Add(txtPasswordLama);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Name = "FrmGantiPassword";
            Text = "FrmGantiPassword";
            Load += FrmGantiPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnKembali;
        private TextBox txtPasswordLama;
        private TextBox txtPasswordBaru;
        private TextBox txtKonfirmasi;
    }
}